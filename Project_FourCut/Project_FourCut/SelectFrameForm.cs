using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FourCut
{
    public partial class SelectFrameForm : Form
    {
        Image[] frameimage =
        {
                Image.FromFile(@"C:\Project_FourCut\File\frame\FourWhite.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\FourBlack.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\Four_little_mermaid.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\Four_chunsik.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\Four_idol.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\TwoWhite.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\TwoBlack.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\Two_little_mermaid.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\Two_chunsik.png"),
                Image.FromFile(@"C:\Project_FourCut\File\frame\Two_idol.png")
        };

        public int i = 1;
        public int result;


        public SelectFrameForm()
        {
            InitializeComponent();
            pictureBox3.Image = (Image)frameimage[0].Clone();
            pictureBox4.Image = (Image)frameimage[5].Clone();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (i == 1)
                result = 0;
            else if (i == 2)
                result = 1;
            else if (i == 3)
                result = 2;
            else if (i == 4)
                result = 3;
            else if (i == 5)
                result = 4;
            Form2 form2 = new Form2(result);                                          //인생네컷 외부프레임 정보 - 결과

            SelectCameraPrictureForm selectCameraPrictureForm = new SelectCameraPrictureForm(result);
            selectCameraPrictureForm.Show();
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (i == 1)
                result = 5;
            else if (i == 2)
                result = 6;
            else if (i == 3)
                result = 7;
            else if (i == 4)
                result = 8;
            else if (i == 5)
                result = 9;
            Form2 form2 = new Form2(result);                                          //인생네컷 외부프레임 정보 - 결과

            SelectCameraPrictureForm selectCameraPrictureForm = new SelectCameraPrictureForm(result);
            selectCameraPrictureForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = (Image)frameimage[0].Clone();
            pictureBox4.Image = (Image)frameimage[5].Clone();
            i = 1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = (Image)frameimage[1].Clone();
            pictureBox4.Image = (Image)frameimage[6].Clone();
            i = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = (Image)frameimage[2].Clone();
            pictureBox4.Image = (Image)frameimage[7].Clone();
            i = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = (Image)frameimage[3].Clone();
            pictureBox4.Image = (Image)frameimage[8].Clone();
            i = 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = (Image)frameimage[4].Clone();
            pictureBox4.Image = (Image)frameimage[9].Clone();
            i = 5;
        }
    }
}
