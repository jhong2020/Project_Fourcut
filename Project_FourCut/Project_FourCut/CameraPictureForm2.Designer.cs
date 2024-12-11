namespace Project_FourCut
{
    partial class CameraPictureForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraPictureForm2));
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Location = new System.Drawing.Point(70, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(640, 480);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(14, 99);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(756, 14);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.LightPink;
            label2.Font = new System.Drawing.Font("평창 평화체 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(378, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(19, 25);
            label2.TabIndex = 17;
            label2.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightPink;
            label1.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(287, -2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 65);
            label1.TabIndex = 16;
            label1.Text = "사진촬영";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(70, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(640, 480);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.LightPink;
            label3.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(553, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 65);
            label3.TabIndex = 20;
            label3.Text = "1 / 8";
            // 
            // CameraPictureForm2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightPink;
            ClientSize = new System.Drawing.Size(784, 621);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CameraPictureForm2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "CameraPictureForm2";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}