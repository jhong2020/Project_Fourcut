using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_FourCut
{
    public partial class Payment : Form
    {
        private int price;

        public Payment()
        {
            InitializeComponent();
        }
        public Payment(int price)
        {
            InitializeComponent();
            this.price = price;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SelectAmountForm selectAmountForm = new SelectAmountForm();
            selectAmountForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "카드를 넣어주세요!";
            panel1.Visible = true;
            timer1.Start();
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label3.Text = "현금을 넣어주세요!";
            panel1.Visible = true;
            timer1.Start();
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = $"{price:C0}원이 결제되었습니다!";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SelectFrameForm selectFrameForm = new SelectFrameForm();
            selectFrameForm.Show();
            Close();
        }
    }
}
