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
    public partial class SelectAmountForm : Form
    {
        public SelectAmountForm()
        {
            InitializeComponent();
        }

        private static int Picture_Amount = 0;
        private static int Price = 0;

        private void OpenPaymentForm()
        {
            Payment payment = new Payment(Price);
            payment.Show();
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Picture_Amount = 2;
            Price = 4000;
            OpenPaymentForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Picture_Amount = 4;
            Price = 8000;
            OpenPaymentForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Picture_Amount = 6;
            Price = 12000;
            OpenPaymentForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Picture_Amount = 8;
            Price = 16000;
            OpenPaymentForm();
        }
    }
}
