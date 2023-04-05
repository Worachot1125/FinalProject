namespace Finalproject
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
            label1 = new Label();
            tbCostRoom = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbPaymoney = new TextBox();
            label4 = new Label();
            tbChange = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "จ่ายเงิน";
            // 
            // tbCostRoom
            // 
            tbCostRoom.Location = new Point(134, 154);
            tbCostRoom.Multiline = true;
            tbCostRoom.Name = "tbCostRoom";
            tbCostRoom.Size = new Size(168, 46);
            tbCostRoom.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 167);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "ค่าที่พัก";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 233);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = "จำนวนเงินที่จ่าย";
            // 
            // tbPaymoney
            // 
            tbPaymoney.Location = new Point(134, 220);
            tbPaymoney.Multiline = true;
            tbPaymoney.Name = "tbPaymoney";
            tbPaymoney.Size = new Size(168, 46);
            tbPaymoney.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 299);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 6;
            label4.Text = "จำนวนเงินทอน";
            // 
            // tbChange
            // 
            tbChange.Location = new Point(134, 284);
            tbChange.Multiline = true;
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(168, 46);
            tbChange.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(174, 350);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "ชำระเงิน";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "เงินสด", "โอนผ่านแอปธนาคาร", "สแกน QR Code", "PayPal" });
            comboBox1.Location = new Point(134, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 28);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 100);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 9;
            label5.Text = "เลือกวิธีชำระ";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(315, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "ปิดโปรแกรม";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(tbChange);
            Controls.Add(label3);
            Controls.Add(tbPaymoney);
            Controls.Add(label2);
            Controls.Add(tbCostRoom);
            Controls.Add(label1);
            Name = "Pay";
            Text = "จ่ายเงิน";
            Load += Pay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCostRoom;
        private Label label2;
        private Label label3;
        private TextBox tbPaymoney;
        private Label label4;
        private TextBox tbChange;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
        private Button button2;
    }
}