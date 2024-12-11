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
    public partial class SelectCameraPrictureForm : Form
    {
        public int index;
        public SelectCameraPrictureForm(int index)
        {
            InitializeComponent();
            this.index = index;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SelectFrameForm selectFrameForm = new SelectFrameForm();
            selectFrameForm.Show();
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CameraPicureForm cameraPicureForm = new CameraPicureForm(index); 
            cameraPicureForm.Show(); 
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CameraPictureForm2 cameraPictureForm2 = new CameraPictureForm2(index);
            cameraPictureForm2.Show();
            Close();
        }
    }
}
