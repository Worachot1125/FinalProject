namespace Finalproject
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            inputMemberToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            tbOpen = new TextBox();
            tbPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btA = new Button();
            btB = new Button();
            btC = new Button();
            btD = new Button();
            btE = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(38, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(835, 179);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ชื่อ";
            Column1.HeaderText = "ชื่อ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "เลขบัตรประชาชน";
            Column2.HeaderText = "เลขบัตรประชาชน";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "เบอร์โทรศัพท์";
            Column3.HeaderText = "เบอร์โทรศัพท์";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "อีเมล";
            Column4.HeaderText = "อีเมล";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "วันที่จอง";
            Column5.HeaderText = "วันที่จอง";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ห้องที่จอง";
            Column6.HeaderText = "ห้องที่จอง";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 64, 0);
            button1.Location = new Point(893, 88);
            button1.Name = "button1";
            button1.Size = new Size(104, 78);
            button1.TabIndex = 2;
            button1.Text = "จ่ายเงิน";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(155, 26);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(155, 26);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inputMemberToolStripMenuItem });
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(79, 24);
            memberToolStripMenuItem.Text = "Member";
            // 
            // inputMemberToolStripMenuItem
            // 
            inputMemberToolStripMenuItem.Name = "inputMemberToolStripMenuItem";
            inputMemberToolStripMenuItem.Size = new Size(224, 26);
            inputMemberToolStripMenuItem.Text = "Input Member";
            inputMemberToolStripMenuItem.Click += inputMemberToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, memberToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1009, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 43);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 3;
            label1.Text = "ระบบจองห้องพัก";
            // 
            // tbOpen
            // 
            tbOpen.Location = new Point(108, 327);
            tbOpen.Multiline = true;
            tbOpen.Name = "tbOpen";
            tbOpen.Size = new Size(765, 36);
            tbOpen.TabIndex = 4;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(640, 284);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(146, 30);
            tbPrice.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 287);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(792, 288);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 7;
            label3.Text = "บาท";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 289);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "ชั้นห้องพัก";
            // 
            // btA
            // 
            btA.ForeColor = Color.Black;
            btA.Location = new Point(150, 283);
            btA.Name = "btA";
            btA.Size = new Size(40, 32);
            btA.TabIndex = 9;
            btA.Text = "A";
            btA.UseVisualStyleBackColor = true;
            btA.Click += btA_Click;
            // 
            // btB
            // 
            btB.ForeColor = Color.Black;
            btB.Location = new Point(196, 283);
            btB.Name = "btB";
            btB.Size = new Size(40, 32);
            btB.TabIndex = 10;
            btB.Text = "B";
            btB.UseVisualStyleBackColor = true;
            btB.Click += btB_Click;
            // 
            // btC
            // 
            btC.ForeColor = Color.Black;
            btC.Location = new Point(242, 283);
            btC.Name = "btC";
            btC.Size = new Size(40, 32);
            btC.TabIndex = 11;
            btC.Text = "C";
            btC.UseVisualStyleBackColor = true;
            btC.Click += btC_Click;
            // 
            // btD
            // 
            btD.ForeColor = Color.Black;
            btD.Location = new Point(288, 283);
            btD.Name = "btD";
            btD.Size = new Size(40, 32);
            btD.TabIndex = 12;
            btD.Text = "D";
            btD.UseVisualStyleBackColor = true;
            btD.Click += btD_Click;
            // 
            // btE
            // 
            btE.ForeColor = Color.Black;
            btE.Location = new Point(334, 283);
            btE.Name = "btE";
            btE.Size = new Size(40, 32);
            btE.TabIndex = 13;
            btE.Text = "E";
            btE.UseVisualStyleBackColor = true;
            btE.Click += btE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 394);
            Controls.Add(btE);
            Controls.Add(btD);
            Controls.Add(btC);
            Controls.Add(btB);
            Controls.Add(btA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPrice);
            Controls.Add(tbOpen);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            ForeColor = Color.White;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "จองที่พัก";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem inputMemberToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label1;
        private TextBox tbOpen;
        private TextBox tbPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btA;
        private Button btB;
        private Button btC;
        private Button btD;
        private Button btE;
    }
}