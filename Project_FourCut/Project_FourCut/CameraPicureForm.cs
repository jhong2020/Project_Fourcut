using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Project_FourCut
{
    public partial class CameraPicureForm : Form
    {
        private VideoCapture capture;
        private Mat frame;
        private Bitmap bitmap;
        private bool isCameraRunning = false;
        private SoundPlayer soundPlayer;

        private Form2 form2;
        private Timer timer;

        public int overlayX = 200; // 오른쪽 여백 10px
        public int overlayY = 0; // 아래쪽 여백 10px

        public int index = 0;  // 기본값은 0으로 설정, 이후 frameIndex로 설정
        public int fileIndex = 1;
        // 오버레이 이미지 필드
        private Bitmap overlayImage; // 오버레이 이미지 필드

        // 파라미터를 받는 생성자 (인덱스를 받아서 설정)
        public CameraPicureForm(int frameIndex)
        {
            InitializeComponent();
            index = frameIndex;  // 전달받은 frameIndex로 index 설정
            InitializeCamera();  // 카메라 초기화

            // 오버레이 이미지 로드
            overlayImage = new Bitmap($"C:\\Project_FourCut\\File\\idolImage\\{fileIndex}.png"); // 오버레이 이미지 경로
        }

        // 카메라 초기화 메서드
        private void InitializeCamera()
        {
            // MouseClick 이벤트 핸들러 등록
            this.MouseClick += new MouseEventHandler(Form3_MouseClick);
            pictureBox1.MouseClick += new MouseEventHandler(PictureBox1_MouseClick);

            // 카메라 시작
            if (!isCameraRunning)
            {
                // 웹캠을 초기화
                capture = new VideoCapture(0); // '0'은 기본 웹캠을 의미합니다.
                capture.Open(0);

                if (!capture.IsOpened())
                {
                    MessageBox.Show("웹캠을 열 수 없습니다.");
                    return;
                }

                isCameraRunning = true;

                // 프레임 업데이트 타이머 설정
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 30; // 30ms마다 프레임을 가져옴
                timer.Tick += new EventHandler(UpdateFrame);
                timer.Start();
            }
            else
            {
                MessageBox.Show("웹캠이 이미 실행 중입니다.");
            }

            soundPlayer = new SoundPlayer("C:\\Project_FourCut\\File\\sound.wav"); // 소리 파일 경로 설정
        }


        private void Form3_MouseClick(object sender, EventArgs e)
        {
            ImageCaptureShow();
        }

        private void PictureBox1_MouseClick(object sender, EventArgs e)
        {
            ImageCaptureShow();
        }

        private void ImageCaptureShow()
        {
            if (frame != null && !frame.Empty())
            {
                // 폼에 출력된 비율대로 프레임 크기 조정
                Mat resizedFrame;

                if (index >= 5)
                {
                    // 폼에 맞춰 프레임을 비율에 맞게 조정 (빈 공간 없이)
                    int height = frame.Height;
                    int width = (int)(height * 0.75);  // 4:3 비율 계산

                    // 중앙에서 자르기
                    int x = (frame.Width - width) / 2;
                    int y = 0;  // 세로 중앙에서 자를 필요 없음

                    // ROI 설정 (중앙을 기준으로 이미지 자르기)
                    Rect roi = new Rect(x, y, width, height);
                    resizedFrame = new Mat(frame, roi);
                }
                else
                {
                    // 기존 크기 조정 로직 사용 (index가 4 이하일 때)
                    resizedFrame = ResizeFrameForSaving(frame);
                }

                // 이미지를 저장할 경로 설정
                string filePath = $"C:\\Project_FourCut\\File\\picture\\{fileIndex}.png";

                // 최종 이미지를 위한 Bitmap 생성
                using (Bitmap finalImage = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                {
                    // index가 4일 때 오버레이 이미지 합성하여 저장
                    if (index == 4)
                    {
                        // 오버레이 이미지 결정
                        int overlayImageIndex = 1;
                        if (fileIndex == 3 || fileIndex == 4) overlayImageIndex = 2;
                        else if (fileIndex == 5 || fileIndex == 6) overlayImageIndex = 3;
                        else if (fileIndex >= 7) overlayImageIndex = 4;

                        string overlayImagePath = $"C:\\Project_FourCut\\File\\idolImage\\{overlayImageIndex}.png";
                        overlayImage = new Bitmap(overlayImagePath);

                        // 비디오 프레임과 오버레이 이미지 합성
                        CenterImageLocation(finalImage, (pictureBox1.Width - resizedFrame.Width) / 2, overlayX, overlayY);
                    }
                    else
                    {
                        // index가 4가 아닐 때는 오버레이 없이 비디오 프레임만 저장
                        using (Graphics g = Graphics.FromImage(finalImage))
                        {
                            g.DrawImage(BitmapConverter.ToBitmap(resizedFrame), 0, 0, pictureBox1.Width, pictureBox1.Height); // 비디오 프레임을 폼 비율에 맞게 저장
                        }
                    }

                    // 이미지를 파일로 저장
                    finalImage.Save(filePath);
                }

                soundPlayer.Play();  // 소리 재생

                fileIndex++;

                // fileIndex가 8을 초과하면 카메라를 닫고 다음 폼을 표시
                if (fileIndex > 8)
                {
                    CloseCamera();
                    form2 = new Form2(index);
                    form2.Show();
                    this.Hide();
                }

                DisplayMatImageAndHide();  // 이미지 디스플레이 후 숨기기
            }
        }











        private void CenterImageLocation(Bitmap centeredBitmap, int centeredX, int overlayX, int overlayY)
        {
            using (Graphics g = Graphics.FromImage(centeredBitmap))
            {
                // 비디오 프레임 그리기
                g.DrawImage(bitmap, centeredX, 0, pictureBox1.Width, pictureBox1.Height);  // 비디오 프레임이 전체를 채우도록 설정

                // 오버레이 이미지 크기 및 위치 계산
                int overlayWidth = (int)(overlayImage.Width * 0.53);  // 크기 조정
                int overlayHeight = (int)(overlayImage.Height * 0.53); // 크기 조정

                // Y 좌표를 올리기 위해 overlayY 값을 감소시킴 (예: 100)
                overlayY -= 120;

                // 빈 레이어를 제거하기 위해 이미지를 중앙으로 맞추고 확대하여 그리기
                int adjustedOverlayX = overlayX - (overlayWidth - overlayImage.Width) / 2;
                int adjustedOverlayY = overlayY - (overlayHeight - overlayImage.Height) / 2;

                // 오버레이 이미지가 화면을 벗어나는지 확인
                if (adjustedOverlayY < 0)
                {
                    // 오버레이 이미지의 Y 위치가 화면을 벗어나면 해당 부분 잘라내기
                    Rectangle srcRect = new Rectangle(0, -adjustedOverlayY, overlayWidth, overlayHeight + adjustedOverlayY);
                    Rectangle destRect = new Rectangle(adjustedOverlayX, 0, overlayWidth, overlayHeight + adjustedOverlayY);
                    g.DrawImage(overlayImage, destRect, srcRect, GraphicsUnit.Pixel);
                }
                else
                {
                    // 오버레이 이미지 그리기 (빈 공간 없이)
                    g.DrawImage(overlayImage, adjustedOverlayX, adjustedOverlayY, overlayWidth, overlayHeight);
                }
            }
        }



        // 사진 저장을 위한 프레임 크기 조정 메서드
        private Mat ResizeFrameForSaving(Mat originalFrame)
        {
            int width, height;
            Rect roi;

            if (index < 5)
            {
                // 기존 조건 유지 (가로 비율 처리)
                if (index == 4)
                {
                    width = originalFrame.Width;
                    height = (int)(originalFrame.Height * 0.90);

                    if (height > originalFrame.Height)
                    {
                        height = originalFrame.Height;
                        width = (int)(originalFrame.Height / 0.90);
                    }
                }
                else
                {
                    width = originalFrame.Width;
                    height = (int)(originalFrame.Height);

                    if (height > originalFrame.Height)
                    {
                        height = originalFrame.Height;
                        width = (int)(originalFrame.Height);
                    }
                }
            }
            else
            {
                // index가 5 이상일 때 세로 비율 유지하면서 빈 공간 없이 꽉 차도록 처리
                height = originalFrame.Height;
                width = (int)(height * 0.75); // 4:3 비율에 맞추기 위한 크기 계산
            }

            int x = (originalFrame.Width - width) / 2;
            int y = (originalFrame.Height - height) / 2;

            if (x < 0) x = 0;
            if (y < 0) y = 0;
            if (x + width > originalFrame.Width) width = originalFrame.Width - x;
            if (y + height > originalFrame.Height) height = originalFrame.Height - y;

            roi = new Rect(x, y, width, height);

            return new Mat(originalFrame, roi);
        }



        private void DisplayMatImageAndHide()
        {
            // Mat을 Bitmap으로 변환하여 표시
            Color originalBackColor = this.BackColor;
            this.BackColor = Color.FromArgb(255, 255, 255);
            Color label1BackColor = this.label1.BackColor;
            this.label1.BackColor = Color.White;
            Color label1textColor = this.label1.ForeColor;
            this.label1.ForeColor = originalBackColor;
            Color label2textColor = this.label2.ForeColor;
            this.label2.ForeColor = originalBackColor;
            Color label3BackColor = this.label3.BackColor;
            this.label3.BackColor = Color.White;
            Color label3textColor = this.label3.ForeColor;
            this.label3.ForeColor = originalBackColor;

            pictureBox3.Image = centeredBitmap;
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;

            // 2초 후에 pictureBox3를 숨기기 위한 타이머 설정
            Timer imageDisplayTimer = new Timer();
            imageDisplayTimer.Interval = 2000; // 2초 후에 숨김
            imageDisplayTimer.Tick += (s, e) =>
            {
                pictureBox3.Visible = false;
                label3.Text = $"{fileIndex} / 8";

                this.BackColor = originalBackColor;
                this.label1.BackColor = label1BackColor;
                this.label1.ForeColor = label1textColor;
                this.label2.ForeColor = label2textColor;
                this.label3.BackColor = label3BackColor;
                this.label3.ForeColor = label3textColor;

                imageDisplayTimer.Stop();
                imageDisplayTimer.Dispose();
            };
            imageDisplayTimer.Start();
        }

        // Mat을 Bitmap으로 변환하는 메서드
        private Bitmap MatToBitmap(Mat mat)
        {
            return BitmapConverter.ToBitmap(mat);  // OpenCvSharp의 BitmapConverter 사용
        }

        private Bitmap centeredBitmap;
        private void UpdateFrame(object sender, EventArgs e)
        {
            if (capture != null && capture.IsOpened())
            {
                frame = new Mat();
                capture.Read(frame);

                // 좌우반전 처리 추가
                Cv2.Flip(frame, frame, FlipMode.Y);

                if (!frame.Empty())
                {
                    // 프레임 크기 조정
                    Mat resizeFrame = ResizeFrameForSaving(frame);

                    // Bitmap 변환
                    bitmap = BitmapConverter.ToBitmap(resizeFrame);
                    centeredBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                    // index가 4 또는 9일 때만 이미지 합성
                    if (index == 4)
                    {
                        // fileIndex에 따라 오버레이 이미지 로드
                        int overlayImageIndex;

                        // 오버레이 이미지를 fileIndex에 따라 결정
                        if (fileIndex == 1 || fileIndex == 2)
                        {
                            overlayImageIndex = 1; // 1.png
                        }
                        else if (fileIndex == 3 || fileIndex == 4)
                        {
                            overlayImageIndex = 2; // 2.png
                        }
                        else if (fileIndex == 5 || fileIndex == 6)
                        {
                            overlayImageIndex = 3; // 3.png
                        }
                        else
                        {
                            overlayImageIndex = 4; // 4.png
                        }

                        string overlayImagePath = $"C:\\Project_FourCut\\File\\idolImage\\{overlayImageIndex}.png"; // 경로에서 이미지 로드
                        overlayImage = new Bitmap(overlayImagePath);

                        // 비디오 프레임과 오버레이 이미지 합성
                        CenterImageLocation(centeredBitmap, (pictureBox1.Width - resizeFrame.Width) / 2, overlayX, overlayY);
                    }
                    else
                    {
                        using (Graphics g = Graphics.FromImage(centeredBitmap))
                        {
                            g.DrawImage(bitmap, (pictureBox1.Width - resizeFrame.Width) / 2, 0); // 비디오 프레임만 그리기
                        }
                    }

                    pictureBox1.Image = centeredBitmap;  // 새로운 이미지 설정
                }
            }
        }

        private void CloseCamera()
        {
            if (capture != null && capture.IsOpened())
            {
                capture.Release();
                capture = null; // capture 변수 null로 설정
            }
        }

        // 폼을 닫을 때 카메라 정지
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            CloseCamera();
            base.OnFormClosed(e);
        }
    }
}