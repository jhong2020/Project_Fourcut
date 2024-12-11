namespace Project_FourCut
{
    partial class SelectAmountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAmountForm));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label1.ForeColor = System.Drawing.Color.LightPink;
            label1.Location = new System.Drawing.Point(284, -1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 65);
            label1.TabIndex = 2;
            label1.Text = "수량선택";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("평창 평화체 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label2.ForeColor = System.Drawing.Color.LightPink;
            label2.Location = new System.Drawing.Point(208, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(338, 25);
            label2.TabIndex = 3;
            label2.Text = "선택한 수량만 동일한 사진이 출력됩니다.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(756, 11);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("평창 평화체 Bold", 59.9999924F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(121, 114);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(240, 240);
            button1.TabIndex = 5;
            button1.Text = "2장";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("평창 평화체 Bold", 59.9999924F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(422, 114);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(240, 240);
            button2.TabIndex = 6;
            button2.Text = "4장";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("평창 평화체 Bold", 59.9999924F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            button3.ForeColor = System.Drawing.Color.White;
            button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
            button3.Location = new System.Drawing.Point(121, 365);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(240, 240);
            button3.TabIndex = 7;
            button3.Text = "6장";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("평창 평화체 Bold", 59.9999924F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 129);
            button4.ForeColor = System.Drawing.Color.White;
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.Location = new System.Drawing.Point(422, 365);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(240, 240);
            button4.TabIndex = 8;
            button4.Text = "8장";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // SelectAmountForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(784, 621);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SelectAmountForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SelectAmountForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}