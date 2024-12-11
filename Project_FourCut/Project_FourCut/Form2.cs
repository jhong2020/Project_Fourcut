using OpenCvSharp.Extensions;
using OpenCvSharp;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project_FourCut
{
    public partial class Form2 : Form
    {
        String[] frameimage =
        {

            "C:\\Project_FourCut\\File\\frame\\FourWhite.png",
            "C:\\Project_FourCut\\File\\frame\\FourBlack.png",
            "C:\\Project_FourCut\\File\\frame\\Four_little_mermaid.png",
            "C:\\Project_FourCut\\File\\frame\\Four_chunsik.png",
            "C:\\Project_FourCut\\File\\frame\\Four_idol.png",
            "C:\\Project_FourCut\\File\\frame\\TwoWhite.png",
            "C:\\Project_FourCut\\File\\frame\\TwoBlack.png",
            "C:\\Project_FourCut\\File\\frame\\Two_little_mermaid.png",
            "C:\\Project_FourCut\\File\\frame\\Two_chunsik.png",
            "C:\\Project_FourCut\\File\\frame\\Two_idol.png"

        };

        public int index = 0;
        public string folderPath = $"C:\\Project_FourCut\\File\\picture\\"; // 이미지가 있는 경로

        // 버튼 배열 선언
        private Button[] imageSelectButtons;
        private Button[] pictureBoxSlots;
        private Button[] imageSelectButtons2;
        private Button[] pictureBoxSlots2;
        // 각 버튼의 원래 이미지 저장
        private Dictionary<Button, Image> originalButtonImages = new Dictionary<Button, Image>();
        private Dictionary<Button, Button> slotImageMap = new Dictionary<Button, Button>();

        // frameIndex를 받아오는 생성자
        public Form2(int frameIndex)
        {
            InitializeComponent();
            index = frameIndex;
            First();
            if (index == 5 || index == 6 || index == 7 || index == 8 || index == 9)
                panel_picture_select.Visible = true;
        }

        // 기본 초기화 함수
        public void First()
        {
            imageSelectButtons = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8 };
            pictureBoxSlots = new Button[] { btn_bone, btn_bsec, btn_bth, btn_bfo };
            imageSelectButtons2 = new Button[] { button9, button10, button11, button12, button13, button14, button15, button16 };
            pictureBoxSlots2 = new Button[] { btn_bone2, btn_bsec2, btn_bth2, btn_bfo2 };

            // 각 버튼에 Paint 이벤트 및 클릭 이벤트 연결
            foreach (var btn in imageSelectButtons)
            {
                btn.Paint += button_Paint;
                btn.Click += ImageSelectButton_Click; // 첫 번째 그룹 클릭 이벤트
                if (!originalButtonImages.ContainsKey(btn))
                {
                    originalButtonImages[btn] = btn.BackgroundImage;
                }
            }

            foreach (var slot in pictureBoxSlots)
            {
                slot.Click += PictureBoxSlot_Click; // 첫 번째 그룹 슬롯 클릭 이벤트
            }

            foreach (var btn in imageSelectButtons2)
            {
                btn.Paint += button_Paint;
                btn.Click += ImageSelectButton2_Click; // 두 번째 그룹 클릭 이벤트
                if (!originalButtonImages.ContainsKey(btn))
                {
                    originalButtonImages[btn] = btn.BackgroundImage;
                }
            }

            foreach (var slot in pictureBoxSlots2)
            {
                slot.Click += PictureBoxSlot2_Click; // 두 번째 그룹 슬롯 클릭 이벤트
            }

            string imagePath = frameimage[index]; // index 값에 맞는 이미지 경로 선택
            LoadImagesToButtons(folderPath); // 첫 번째 그룹 버튼에 이미지 로드
            LoadImagesToButtons2(folderPath); // 두 번째 그룹 버튼에 이미지 로드
            SetPictureBoxBackgroundImage(imagePath); // pictureBox 배경 이미지 설정
        }

        private void button_Paint(object sender, PaintEventArgs e)
        {
            Button button = sender as Button;
            e.Graphics.Clear(button.BackColor);
            if (button.BackgroundImage != null)
            {
                e.Graphics.DrawImage(button.BackgroundImage, new Rectangle(0, 0, button.Width, button.Height));
            }
        }

        private void SetPictureBoxBackgroundImage(string imagePath)
        {
            if (System.IO.File.Exists(imagePath))
            {
                Mat mat = Cv2.ImRead(imagePath);
                Bitmap bitmap = BitmapConverter.ToBitmap(mat);
                pictureBox1.BackgroundImage = bitmap;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox3.BackgroundImage = bitmap;
                pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                MessageBox.Show($"{imagePath} 파일을 찾을 수 없습니다.");
            }
        }

        // 첫 번째 그룹의 버튼에 이미지 로드
        private void LoadImagesToButtons(string folderPath)
        {
            for (int i = 0; i < imageSelectButtons.Length; i++)
            {
                string imagePath = $"{folderPath}{i + 1}.png"; // 각 버튼에 대응하는 이미지 경로
                if (System.IO.File.Exists(imagePath))
                {
                    Mat mat = Cv2.ImRead(imagePath);
                    Bitmap bitmap = BitmapConverter.ToBitmap(mat);
                    imageSelectButtons[i].BackgroundImage = bitmap;
                    imageSelectButtons[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void LoadImagesToButtons2(string folderPath)
        {
            for (int i = 0; i < imageSelectButtons2.Length; i++)
            {
                string imagePath = $"{folderPath}{i + 1}.png";
                if (System.IO.File.Exists(imagePath))
                {
                    Mat mat = Cv2.ImRead(imagePath);
                    Bitmap bitmap = BitmapConverter.ToBitmap(mat);
                    imageSelectButtons2[i].BackgroundImage = bitmap;
                    imageSelectButtons2[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        // 첫 번째 그룹의 이미지 선택 버튼 클릭 처리
        private void ImageSelectButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            foreach (var slot in pictureBoxSlots)
            {
                if (slot.BackgroundImage == null) // 슬롯이 비어 있으면
                {
                    slot.BackgroundImage = clickedButton.BackgroundImage;
                    slotImageMap[slot] = clickedButton;

                    originalButtonImages[clickedButton] = clickedButton.BackgroundImage;
                    clickedButton.BackgroundImage = MakeImageTransparent(new Bitmap(clickedButton.BackgroundImage), 0.5f);
                    clickedButton.Enabled = false; // 비활성화
                    return;
                }
            }
            MessageBox.Show("모든 슬롯이 이미 채워졌습니다.");
        }

        // 두 번째 그룹의 이미지 선택 버튼 클릭 처리
        private void ImageSelectButton2_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            foreach (var slot in pictureBoxSlots2)
            {
                if (slot.BackgroundImage == null) // 슬롯이 비어 있으면
                {
                    slot.BackgroundImage = clickedButton.BackgroundImage;
                    slotImageMap[slot] = clickedButton;

                    originalButtonImages[clickedButton] = clickedButton.BackgroundImage;
                    clickedButton.BackgroundImage = MakeImageTransparent(new Bitmap(clickedButton.BackgroundImage), 0.5f);
                    clickedButton.Enabled = false; // 비활성화
                    return;
                }
            }
            MessageBox.Show("모든 슬롯이 이미 채워졌습니다.");
        }

        // 첫 번째 그룹의 슬롯 클릭 시 이미지 복구 처리
        private void PictureBoxSlot_Click(object sender, EventArgs e)
        {
            Button clickedSlot = (Button)sender;
            if (clickedSlot.BackgroundImage != null && slotImageMap.ContainsKey(clickedSlot))
            {
                Button associatedButton = slotImageMap[clickedSlot];
                if (originalButtonImages.ContainsKey(associatedButton))
                {
                    associatedButton.Enabled = true;  // 버튼을 다시 활성화
                    associatedButton.BackgroundImage = originalButtonImages[associatedButton]; // 원래 이미지 복구
                }
                clickedSlot.BackgroundImage = null;
                slotImageMap.Remove(clickedSlot);
            }
        }

        // 두 번째 그룹의 슬롯 클릭 시 이미지 복구 처리
        private void PictureBoxSlot2_Click(object sender, EventArgs e)
        {
            Button clickedSlot = (Button)sender;
            if (clickedSlot.BackgroundImage != null && slotImageMap.ContainsKey(clickedSlot))
            {
                Button associatedButton = slotImageMap[clickedSlot];
                if (originalButtonImages.ContainsKey(associatedButton))
                {
                    associatedButton.Enabled = true;  // 버튼을 다시 활성화
                    associatedButton.BackgroundImage = originalButtonImages[associatedButton]; // 원래 이미지 복구
                }
                clickedSlot.BackgroundImage = null;
                slotImageMap.Remove(clickedSlot);
            }
        }

        // btn_result 클릭 시 각 버튼의 백그라운드 이미지를 모으는 메서드
        private void btn_result_Click(object sender, EventArgs e)
        {

            // btn_bone, btn_bsec, btn_bth, btn_bfo의 BackgroundImage를 배열에 저장
            Image[] buttonImages = { btn_bone.BackgroundImage, btn_bsec.BackgroundImage, btn_bth.BackgroundImage, btn_bfo.BackgroundImage };

            // pictureBox1의 배경 이미지 가져오기
            Image pictureBoxImage = pictureBox1.BackgroundImage;

            foreach (var buttonImage in buttonImages)
            {
                if (buttonImage == null)
                {
                    MessageBox.Show("사진을 다 채우세요.");
                    return; // 메시지를 표시한 후 메서드를 종료
                }
            }

            if (pictureBoxImage != null)
            {
                // Bitmap으로 변환
                Bitmap combinedImage = new Bitmap(pictureBoxImage.Width, pictureBoxImage.Height);

                // Graphics 객체를 사용하여 이미지를 합치는 작업 수행
                using (Graphics g = Graphics.FromImage(combinedImage))
                {
                    // 보간 모드 설정
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    // PictureBox 이미지를 그립니다.
                    g.DrawImage(pictureBoxImage, new Rectangle(0, 0, combinedImage.Width, combinedImage.Height));

                    // 버튼 이미지를 각 버튼의 좌표에 맞게 그립니다.
                    for (int i = 0; i < buttonImages.Length; i++)
                    {
                        if (buttonImages[i] != null)
                        {
                            int x = 12; // X 좌표는 동일
                            int y = 11 + (i * 96); // Y 좌표는 증가

                            g.DrawImage(buttonImages[i], new Rectangle(x, y, 143, 87)); // 크기를 140 87 조정
                        }
                    }
                }

                // 최종적으로 합쳐진 이미지를 pictureBox에 설정
                pictureBox1.BackgroundImage = combinedImage;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                // 이미지 저장
                string savePath = "C:\\Project_FourCut\\File\\result\\combined_image.png"; // 저장할 경로
                try
                {
                    combinedImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지 저장 중 오류가 발생했습니다: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("pictureBox의 이미지가 없습니다.");
            }

            string folderPath = "C:\\Project_FourCut\\File\\picture\\";

            // 경로에 있는 모든 이미지 파일 삭제
            try
            {
                var imageFiles = System.IO.Directory.GetFiles(folderPath, "*.png"); // PNG 파일들만 검색
                foreach (var file in imageFiles)
                {
                    System.IO.File.Delete(file); // 파일 삭제
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지 삭제 중 오류가 발생했습니다: {ex.Message}");
            }
            FinalForm finalForm = new FinalForm();
            finalForm.Show();
            Close();

        }

        // 이미지의 투명도를 조정하는 함수
        private Image MakeImageTransparent(Image originalImage, float opacity)
        {
            if (originalImage == null) return null;

            Bitmap bmp = new Bitmap(originalImage.Width, originalImage.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // 투명도 조정

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                g.DrawImage(originalImage, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }


        private void btn_result2_Click(object sender, EventArgs e)
        {
            Image[] buttonImages = { btn_bone2.BackgroundImage, btn_bsec2.BackgroundImage, btn_bth2.BackgroundImage, btn_bfo2.BackgroundImage };

            // pictureBox1의 배경 이미지 가져오기
            Image pictureBoxImage = pictureBox3.BackgroundImage;

            foreach (var buttonImage in buttonImages)
            {
                if (buttonImage == null)
                {
                    MessageBox.Show("사진을 다 채우세요.");
                    return; // 메시지를 표시한 후 메서드를 종료
                }
            }

            if (pictureBoxImage != null)
            {
                // Bitmap으로 변환
                Bitmap combinedImage = new Bitmap(pictureBoxImage.Width, pictureBoxImage.Height);

                // Graphics 객체를 사용하여 이미지를 합치는 작업 수행
                using (Graphics g = Graphics.FromImage(combinedImage))
                {
                    // 보간 모드 설정
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    // PictureBox 이미지를 그립니다.
                    g.DrawImage(pictureBoxImage, new Rectangle(0, 0, combinedImage.Width, combinedImage.Height));

                    // 버튼 이미지를 각 버튼의 좌표에 맞게 그립니다.
                    System.Drawing.Point[] positions = new System.Drawing.Point[]
                    {
                        new System.Drawing.Point(14, 20),   // 첫 번째 이미지 위치
                        new System.Drawing.Point(204, 20),  // 두 번째 이미지 위치
                        new System.Drawing.Point(14, 274),  // 세 번째 이미지 위치
                        new System.Drawing.Point(204, 274)   // 네 번째 이미지 위치
                    };

                    for (int i = 0; i < buttonImages.Length; i++)
                    {
                        if (buttonImages[i] != null)
                        {
                            // 버튼 이미지를 지정된 위치에 그리기
                            g.DrawImage(buttonImages[i], new Rectangle(positions[i], new System.Drawing.Size(182, 245))); // 이미지 크기를 조정
                        }
                    }
                }

                // 최종적으로 합쳐진 이미지를 pictureBox에 설정
                pictureBox1.BackgroundImage = combinedImage;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                // 이미지 저장
                string savePath = "C:\\Project_FourCut\\File\\result\\combined_image.png"; // 저장할 경로
                try
                {
                    combinedImage.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"이미지 저장 중 오류가 발생했습니다: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("pictureBox의 이미지가 없습니다.");
            }

            string folderPath = "C:\\Project_FourCut\\File\\picture\\";

            // 경로에 있는 모든 이미지 파일 삭제
            try
            {
                var imageFiles = System.IO.Directory.GetFiles(folderPath, "*.png"); // PNG 파일들만 검색
                foreach (var file in imageFiles)
                {
                    System.IO.File.Delete(file); // 파일 삭제
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"이미지 삭제 중 오류가 발생했습니다: {ex.Message}");
            }
            FinalForm finalForm = new FinalForm();
            finalForm.Show();
            Close();
        }
    }
}
