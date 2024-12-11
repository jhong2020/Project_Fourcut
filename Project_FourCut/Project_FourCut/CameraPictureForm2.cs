using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using static System.Windows.Forms.DataFormats;

namespace Project_FourCut
{
    public partial class CameraPictureForm2 : Form
    {

        private VideoCapture capture;
        private Mat frame;
        private Bitmap bitmap;
        private bool isCameraRunning = false;
        private SoundPlayer soundPlayer = new SoundPlayer("C:\\Project_FourCut\\File\\sound.wav"); // 소리 파일 경로로 변경

        private Timer timer;
        private Timer timer1; // 카운트 다운
        private int countdownValue = 5; // 카운트다운 20초
        private int fileIndex; // 이미지 파일 저장 인덱스
        private bool isForm2Shown = false; //폼2 showing

        // 픽쳐박스 업데이트
        //private int frameIndex = 3;
        private Bitmap centeredBitmap;
        private Rect roi;
        private Mat resizeFrame;

        public int index = 0;

        public CameraPictureForm2(int frameIndex)
        {
            InitializeComponent();
            index = frameIndex;
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            // 타이머 설정 (프레임을 주기적으로 업데이트하기 위함)
            timer = new Timer();
            timer.Interval = 30;
            timer.Tick += new EventHandler(UpdatePictureBox);
            timer.Start();

            // 촬영 30초 카운트다운 타이머
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

            fileIndex = 1;

            if (!isForm2Shown)
            {
                StartCamera();
                StartCountdown();
            }
        }

        private void StartCamera()
        {
            if (!isCameraRunning)
            {
                capture = new VideoCapture(0);
                capture.Open(0);

                if (!capture.IsOpened())
                {
                    MessageBox.Show("웹캠을 열 수 없습니다.");
                    return;
                }
                isCameraRunning = true;
            }
            else
            {
                MessageBox.Show("웹캠이 이미 실행 중입니다.");
            }
        }


        // 카운트다운 시작 메서드
        private void StartCountdown()
        {
            countdownValue = 1;
            timer1.Start();
        }


        // 카운트다운 타이머 Tick 이벤트
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdownValue > 0)
            {
                label2.Text = countdownValue.ToString() + "초";
                countdownValue--;
            }
            else
            {
                timer1.Stop();
                label2.Text = "";
                DisplayPictureBox3();
                Save_Image();
            }
        }


        private void UpdatePictureBox(object sender, EventArgs e)
        {
            if (capture != null && capture.IsOpened())
            {
                frame = new Mat();
                capture.Read(frame);

                if (!frame.Empty())
                {
                    int width, height;
                    int x, y;

                    // 프레임 크기 조정
                    if (index < 5)
                    {
                        width = frame.Width;
                        height = (int)(frame.Height * 0.90);
                        if (height > frame.Height)
                        {
                            height = frame.Height;
                            width = (int)(frame.Height / 0.90);
                        }
                        x = (frame.Width - width) / 2;
                        y = (frame.Height - height) / 2;
                        roi = new Rect(x, y, width, height);
                    }
                    else
                    {
                        width = frame.Width;
                        height = (int)(frame.Height * 1.34);
                        if (height > frame.Height)
                        {
                            height = frame.Height;
                            width = (int)(frame.Height / 1.34);
                        }
                        x = (frame.Width - width) / 2;
                        y = (frame.Height - height) / 2;
                        roi = new Rect(x, y, width, height);
                    }

                    resizeFrame = new Mat(frame, roi); // resizeFrame 초기화

                    // PictureBox 업데이트
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose(); // 기존 이미지 삭제
                    }

                    bitmap = BitmapConverter.ToBitmap(resizeFrame);
                    centeredBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    CenterImageLocation(centeredBitmap, (pictureBox1.Width - resizeFrame.Width) / 2);
                    pictureBox1.Image = centeredBitmap; // 새로운 이미지 설정
                }
            }
        }

        private void CenterImageLocation(Bitmap centeredBitmap, int centeredX)
        {
            using (Graphics g = Graphics.FromImage(centeredBitmap))
            {
                g.DrawImage(bitmap, centeredX, 0); // 수평 중앙에 맞추어 그리기
            }
        }

        private void DisplayPictureBox3()
        {
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


            pictureBox3.Image = centeredBitmap; // pictureBox3에 Bitmap 설정
            pictureBox3.BringToFront(); // pictureBox3를 최전면으로 가져오기
            pictureBox3.Visible = true; // pictureBox3 보이기


            // 2초 후에 pictureBox3를 숨기기 위한 타이머 설정
            Timer imageDisplayTimer = new Timer();
            imageDisplayTimer.Interval = 2000; // 2000 ms = 2초
            imageDisplayTimer.Tick += (s, e) =>
            {
                pictureBox3.Visible = false; // pictureBox3 숨기기

                label3.Text = $"{fileIndex} / 8";

                this.BackColor = originalBackColor;
                this.label1.BackColor = label1BackColor;
                this.label1.ForeColor = label1textColor;
                this.label2.ForeColor = label2textColor;
                this.label3.BackColor = label3BackColor;
                this.label3.ForeColor = label3textColor;

                imageDisplayTimer.Stop(); // 타이머 중지

                imageDisplayTimer.Dispose(); // 타이머 리소스 해제

                StartCountdown();

            };
            imageDisplayTimer.Start();

        }

        //사진 저장을 위한 프레임 크기 조정 메서드
        private void Save_Image()
        {
            // resizeFrame이 null인지 확인
            if (resizeFrame != null && fileIndex >= 1 && fileIndex <= 8)
            {
                // 현재 프레임을 이미지 파일로 저장
                string filePath = $"C:\\Project_FourCut\\File\\picture\\{fileIndex}.png";
                resizeFrame.SaveImage(filePath);
                soundPlayer.Play(); // 소리재생

                fileIndex++;

                // fileIndex가 8에 도달했을 때 카메라 종료, 폼 닫기, Form2로 이동
                if (fileIndex > 8)
                {
                    CloseCamera(); // 카메라 종료
                    this.Hide(); // 현재 폼 숨기기
                    Form2 form2 = new Form2(index); // Form2 생성
                    form2.Show(); // Form2 보여주기
                    this.Hide(); // 현재 폼 닫기
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


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (capture != null && capture.IsOpened())
            {
                capture.Release();
            }
            base.OnFormClosing(e);
        }
    }
}
