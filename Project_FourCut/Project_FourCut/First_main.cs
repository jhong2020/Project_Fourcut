using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FourCut
{
    public partial class First_main : Form
    {
        public First_main()
        {
            InitializeComponent();

            string videoPath = "C:\\Project_FourCut\\File\\Main.mp4";
            //File.WriteAllBytes(videoPath); // 'Main'은 리소스의 이름

            // 비디오 재생 설정
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.uiMode = "none"; // UI 모드 숨김
            axWindowsMediaPlayer1.settings.setMode("stretch", true);
            axWindowsMediaPlayer1.settings.setMode("loop", true); // 무한 반복 재생 설정

        }

        private void axWindowsMediaPlayer1_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            SelectAmountForm selectAmountForm = new SelectAmountForm();
            selectAmountForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SelectAmountForm selectAmountForm = new SelectAmountForm();
            selectAmountForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SelectAmountForm selectAmountForm = new SelectAmountForm();
            selectAmountForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SelectAmountForm selectAmountForm = new SelectAmountForm();
            selectAmountForm.Show();
        }

        private void First_main_MouseClick(object sender, MouseEventArgs e)
        {
            SelectAmountForm selectAmountForm = new SelectAmountForm();
            selectAmountForm.Show();
        }
    }
}
