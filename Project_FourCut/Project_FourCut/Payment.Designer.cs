namespace Project_FourCut
{
    partial class Payment
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(16, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(756, 13);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("평창 평화체 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(276, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(236, 25);
            label2.TabIndex = 6;
            label2.Text = "결제하실 수단을 선택하세요";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightPink;
            label1.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(245, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(298, 65);
            label1.TabIndex = 5;
            label1.Text = "결제방법선택";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("평창 평화체 Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(16, 151);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(370, 362);
            button1.TabIndex = 8;
            button1.Text = "카드";
            button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("평창 평화체 Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(402, 151);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(370, 362);
            button2.TabIndex = 9;
            button2.Text = "현금";
            button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("평창 평화체 Light", 27.7499962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            button3.Location = new System.Drawing.Point(330, 546);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(120, 51);
            button3.TabIndex = 10;
            button3.Text = "이전";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new System.Drawing.Point(16, 151);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(756, 362);
            panel1.TabIndex = 11;
            panel1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.LightPink;
            label4.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(69, 147);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 65);
            label4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.LightPink;
            label3.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(178, 147);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 65);
            label3.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 4000;
            timer2.Tick += timer2_Tick;
            // 
            // Payment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightPink;
            ClientSize = new System.Drawing.Size(784, 621);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Payment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}