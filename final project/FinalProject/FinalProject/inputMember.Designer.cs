namespace FinalProject
{
    partial class inputMember
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
            tbName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbID = new TextBox();
            label3 = new Label();
            tbPhone = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            labelTime = new Label();
            tbEmail = new TextBox();
            cbbRoom = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btComfirm = new Button();
            btClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(119, 51);
            tbName.Name = "tbName";
            tbName.Size = new Size(238, 27);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 55);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 1;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "เลขบัตรประชาชน";
            // 
            // tbID
            // 
            tbID.Location = new Point(119, 96);
            tbID.Name = "tbID";
            tbID.Size = new Size(238, 27);
            tbID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 144);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "เบอร์โทรศัพท์";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(119, 140);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(238, 27);
            tbPhone.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelTime);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(cbbRoom);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(16, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 343);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลผู้จอง";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 189);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "อีเมล";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(283, 255);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(0, 20);
            labelTime.TabIndex = 10;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(119, 186);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(238, 27);
            tbEmail.TabIndex = 9;
            // 
            // cbbRoom
            // 
            cbbRoom.FormattingEnabled = true;
            cbbRoom.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5", "E1", "E2", "E3", "E4", "E5" });
            cbbRoom.Location = new Point(56, 300);
            cbbRoom.Name = "cbbRoom";
            cbbRoom.Size = new Size(100, 28);
            cbbRoom.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 300);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 9;
            label4.Text = "ห้องที่";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(56, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // btComfirm
            // 
            btComfirm.BackColor = Color.Black;
            btComfirm.ForeColor = Color.Yellow;
            btComfirm.Location = new Point(108, 396);
            btComfirm.Name = "btComfirm";
            btComfirm.Size = new Size(94, 29);
            btComfirm.TabIndex = 7;
            btComfirm.Text = "ยืนยันจอง";
            btComfirm.UseVisualStyleBackColor = false;
            btComfirm.Click += btComfirm_Click;
            // 
            // btClear
            // 
            btClear.BackColor = Color.FromArgb(192, 192, 0);
            btClear.Location = new Point(240, 396);
            btClear.Name = "btClear";
            btClear.Size = new Size(94, 29);
            btClear.TabIndex = 8;
            btClear.Text = "ล้างข้อมูล";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // inputMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 468);
            Controls.Add(btClear);
            Controls.Add(btComfirm);
            Controls.Add(groupBox1);
            Name = "inputMember";
            Text = "ข้อมูลผู้จอง";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbID;
        private Label label3;
        private TextBox tbPhone;
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbbRoom;
        private Button btComfirm;
        private Button btClear;
        private Label labelTime;
        private Label label5;
        private TextBox tbEmail;
    }
}