namespace GambluUsume
{
    partial class Form6
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
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(228, 196);
            button1.Name = "button1";
            button1.Size = new Size(119, 53);
            button1.TabIndex = 1;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(168, 160);
            label6.Name = "label6";
            label6.Size = new Size(123, 21);
            label6.TabIndex = 16;
            label6.Text = "Forma - wartość";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(168, 98);
            label5.Name = "label5";
            label5.Size = new Size(176, 21);
            label5.TabIndex = 15;
            label5.Text = "Wytrzymałość - wartość";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(168, 40);
            label4.Name = "label4";
            label4.Size = new Size(141, 21);
            label4.TabIndex = 14;
            label4.Text = "Prędkość - wartość";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(168, 77);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 13;
            label3.Text = "Wytrzymałość";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(168, 139);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 12;
            label2.Text = "Forma";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(168, 19);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 11;
            label1.Text = "Prędkość";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Untitled930_20260112214053;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 261);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Oguri Kap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}