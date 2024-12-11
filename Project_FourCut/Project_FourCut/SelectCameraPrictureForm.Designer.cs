namespace Project_FourCut
{
    partial class SelectCameraPrictureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCameraPrictureForm));
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("평창 평화체 Light", 27.7499962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            button3.Location = new System.Drawing.Point(330, 558);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(120, 51);
            button3.TabIndex = 17;
            button3.Text = "이전";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("평창 평화체 Light", 23.9999962F);
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button2.Location = new System.Drawing.Point(400, 163);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(370, 362);
            button2.TabIndex = 16;
            button2.Text = "자동촬영\r\n#10초 자동촬영";
            button2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("평창 평화체 Light", 23.9999962F);
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            button1.Location = new System.Drawing.Point(14, 163);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(370, 362);
            button1.TabIndex = 15;
            button1.Text = "리모컨촬영\r\n#4컷 80초\r\n#리모컨 촬영 방식";
            button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(14, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(756, 13);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("평창 평화체 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(274, 77);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(234, 31);
            label2.TabIndex = 13;
            label2.Text = "촬영하실 수단을 선택하세요";
            label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightPink;
            label1.Font = new System.Drawing.Font("평창 평화체 Light", 35.9999962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(243, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(298, 65);
            label1.TabIndex = 12;
            label1.Text = "촬영방법선택";
            // 
            // SelectCameraPrictureForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightPink;
            ClientSize = new System.Drawing.Size(784, 621);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SelectCameraPrictureForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SelectCameraPrictureForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}