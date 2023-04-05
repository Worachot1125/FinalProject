namespace Final_Project_OOP.Parking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem1 = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            textBoxCar = new TextBox();
            textBoxEmail = new TextBox();
            textBoxNumber = new TextBox();
            textBoxName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            label6 = new Label();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox2 = new GroupBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1377, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, SaveToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            // 
            // SaveToolStripMenuItem1
            // 
            SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
            SaveToolStripMenuItem1.Size = new Size(128, 26);
            SaveToolStripMenuItem1.Text = "Save";
            SaveToolStripMenuItem1.Click += SaveToolStripMenuItem1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCar);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxNumber);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "โปรดใส่ข้อมูล";
            // 
            // textBoxCar
            // 
            textBoxCar.Location = new Point(29, 296);
            textBoxCar.Multiline = true;
            textBoxCar.Name = "textBoxCar";
            textBoxCar.Size = new Size(128, 33);
            textBoxCar.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(146, 169);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(206, 35);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(146, 110);
            textBoxNumber.Multiline = true;
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(206, 35);
            textBoxNumber.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(146, 62);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 32);
            textBoxName.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 239);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 27);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2022, 4, 8, 2, 20, 1, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(183, 300);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "ที่จอดรถ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 246);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 3;
            label4.Text = "เวลา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 184);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "อีเมล";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 125);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "เลขบัตรประชาชน";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 65);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(41, 427);
            button1.Name = "button1";
            button1.Size = new Size(128, 55);
            button1.TabIndex = 2;
            button1.Text = "เช็คอิน";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(209, 427);
            button2.Name = "button2";
            button2.Size = new Size(128, 55);
            button2.TabIndex = 3;
            button2.Text = "เช็คเอาท์";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column8, Column4, Column5 });
            dataGridView1.Location = new Point(432, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(838, 233);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "ชื่อ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "เลขบัตรประชาชน";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "อีเมล";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "วันที่";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "เวลา";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "ที่จอดรถ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            button3.Location = new Point(134, 513);
            button3.Name = "button3";
            button3.Size = new Size(119, 42);
            button3.TabIndex = 5;
            button3.Text = "ล้าง";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.CornflowerBlue;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(785, 300);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 36;
            label6.Text = "เลือกที่จอด";
            // 
            // button4
            // 
            button4.BackColor = Color.Aqua;
            button4.ForeColor = Color.Red;
            button4.Location = new Point(1240, 546);
            button4.Name = "button4";
            button4.Size = new Size(94, 31);
            button4.TabIndex = 67;
            button4.Text = "จ่ายตังค์";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox19);
            groupBox2.Controls.Add(checkBox20);
            groupBox2.Controls.Add(checkBox21);
            groupBox2.Controls.Add(checkBox22);
            groupBox2.Controls.Add(checkBox23);
            groupBox2.Controls.Add(checkBox24);
            groupBox2.Controls.Add(checkBox13);
            groupBox2.Controls.Add(checkBox14);
            groupBox2.Controls.Add(checkBox15);
            groupBox2.Controls.Add(checkBox16);
            groupBox2.Controls.Add(checkBox17);
            groupBox2.Controls.Add(checkBox18);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Controls.Add(checkBox10);
            groupBox2.Controls.Add(checkBox11);
            groupBox2.Controls.Add(checkBox12);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Location = new Point(432, 336);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(790, 241);
            groupBox2.TabIndex = 68;
            groupBox2.TabStop = false;
            groupBox2.Text = "ที่จอดรถ";
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point(701, 215);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(65, 24);
            checkBox19.TabIndex = 90;
            checkBox19.Text = "DT06";
            checkBox19.UseVisualStyleBackColor = true;
            checkBox19.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point(585, 215);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(65, 24);
            checkBox20.TabIndex = 89;
            checkBox20.Text = "DT05";
            checkBox20.UseVisualStyleBackColor = true;
            checkBox20.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point(471, 215);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(65, 24);
            checkBox21.TabIndex = 88;
            checkBox21.Text = "DT04";
            checkBox21.UseVisualStyleBackColor = true;
            checkBox21.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point(248, 215);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(65, 24);
            checkBox22.TabIndex = 87;
            checkBox22.Text = "DT03";
            checkBox22.UseVisualStyleBackColor = true;
            checkBox22.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point(132, 215);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(65, 24);
            checkBox23.TabIndex = 86;
            checkBox23.Text = "DT02";
            checkBox23.UseVisualStyleBackColor = true;
            checkBox23.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox24
            // 
            checkBox24.AutoSize = true;
            checkBox24.Location = new Point(18, 215);
            checkBox24.Name = "checkBox24";
            checkBox24.Size = new Size(65, 24);
            checkBox24.TabIndex = 85;
            checkBox24.Text = "DT01";
            checkBox24.UseVisualStyleBackColor = true;
            checkBox24.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(701, 170);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(64, 24);
            checkBox13.TabIndex = 84;
            checkBox13.Text = "CT06";
            checkBox13.UseVisualStyleBackColor = true;
            checkBox13.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(585, 170);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(64, 24);
            checkBox14.TabIndex = 83;
            checkBox14.Text = "CT05";
            checkBox14.UseVisualStyleBackColor = true;
            checkBox14.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(471, 170);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(64, 24);
            checkBox15.TabIndex = 82;
            checkBox15.Text = "CT04";
            checkBox15.UseVisualStyleBackColor = true;
            checkBox15.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(248, 170);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(64, 24);
            checkBox16.TabIndex = 81;
            checkBox16.Text = "CT03";
            checkBox16.UseVisualStyleBackColor = true;
            checkBox16.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(132, 170);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(64, 24);
            checkBox17.TabIndex = 80;
            checkBox17.Text = "CT02";
            checkBox17.UseVisualStyleBackColor = true;
            checkBox17.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(18, 170);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(64, 24);
            checkBox18.TabIndex = 79;
            checkBox18.Text = "CT01";
            checkBox18.UseVisualStyleBackColor = true;
            checkBox18.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(702, 75);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(63, 24);
            checkBox7.TabIndex = 78;
            checkBox7.Text = "BT06";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(586, 75);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(63, 24);
            checkBox8.TabIndex = 77;
            checkBox8.Text = "BT05";
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(472, 75);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(63, 24);
            checkBox9.TabIndex = 76;
            checkBox9.Text = "BT04";
            checkBox9.UseVisualStyleBackColor = true;
            checkBox9.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(248, 75);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(63, 24);
            checkBox10.TabIndex = 75;
            checkBox10.Text = "BT03";
            checkBox10.UseVisualStyleBackColor = true;
            checkBox10.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(132, 75);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(63, 24);
            checkBox11.TabIndex = 74;
            checkBox11.Text = "BT02";
            checkBox11.UseVisualStyleBackColor = true;
            checkBox11.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(19, 75);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(63, 24);
            checkBox12.TabIndex = 73;
            checkBox12.Text = "BT01";
            checkBox12.UseVisualStyleBackColor = true;
            checkBox12.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(702, 26);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(64, 24);
            checkBox6.TabIndex = 72;
            checkBox6.Text = "AT06";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(586, 26);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(64, 24);
            checkBox5.TabIndex = 71;
            checkBox5.Text = "AT05";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(471, 26);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(64, 24);
            checkBox4.TabIndex = 70;
            checkBox4.Text = "AT04";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(248, 26);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(64, 24);
            checkBox3.TabIndex = 69;
            checkBox3.Text = "AT03";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(132, 26);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 24);
            checkBox2.TabIndex = 68;
            checkBox2.Text = "AT02";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(19, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 24);
            checkBox1.TabIndex = 67;
            checkBox1.Text = "AT01";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 614);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBoxCar;
        private TextBox textBoxEmail;
        private TextBox textBoxNumber;
        private TextBox textBoxName;
        private Button button3;
        private Label label6;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private GroupBox groupBox2;
        private CheckBox checkBox19;
        private CheckBox checkBox20;
        private CheckBox checkBox21;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox checkBox18;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}