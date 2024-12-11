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
    public partial class FinalForm : Form
    {

        private int currentCharIndex = 0;
        public FinalForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void CloseFormAfterDelay(object sender, EventArgs e)
        {
            timer1.Stop(); 
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Visible = true;

            if (currentCharIndex < label2.Text.Length)
            {
                timer1.Interval = 400;
                label3.Text += label2.Text[currentCharIndex];
                currentCharIndex++;
                label3.Font = label2.Font; 
                label3.ForeColor = label2.ForeColor; 
            }
            else
            {
                label3.Text = "";
                panel1.Visible = true;
                pictureBox1.Image = Image.FromFile(@"C:\Project_FourCut\File\result\combined_image.png");
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


                timer1.Interval = 5000; 
                timer1.Tick -= timer1_Tick; 
                timer1.Tick += CloseFormAfterDelay; 
            }
        }
    }
}
