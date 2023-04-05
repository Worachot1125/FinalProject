namespace Final_Project_OOP.Parking
{
    partial class Pay
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            imageList1 = new ImageList(components);
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(259, 427);
            button1.Name = "button1";
            button1.Size = new Size(89, 34);
            button1.TabIndex = 1;
            button1.Text = "กลับ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(462, 128);
            button2.Name = "button2";
            button2.Size = new Size(165, 44);
            button2.TabIndex = 2;
            button2.Text = "ใช่บัตรสมาชิกที่จอดรถ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.Location = new Point(188, 169);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 54);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(192, 91);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 54);
            textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 247);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 54);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 331);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(242, 54);
            textBox4.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.Moccasin;
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(462, 304);
            button3.Name = "button3";
            button3.Size = new Size(165, 44);
            button3.TabIndex = 9;
            button3.Text = "จ่าย";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 86);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 11;
            label1.Text = "ค่าจอดรถ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 169);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 12;
            label2.Text = "ค่าจอดรถปัจจุบัน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 262);
            label3.Name = "label3";
            label3.Size = new Size(41, 28);
            label3.TabIndex = 13;
            label3.Text = "จ่าย";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(44, 345);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 14;
            label4.Text = "ทอน";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Tomato;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(259, 29);
            label5.Name = "label5";
            label5.Size = new Size(81, 29);
            label5.TabIndex = 15;
            label5.Text = "จ่ายเงิน";
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(639, 530);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Pay";
            Text = "Pay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ImageList imageList1;
        private Label label5;
    }
}