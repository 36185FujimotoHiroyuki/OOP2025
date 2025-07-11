namespace CaReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpDate = new DateTimePicker();
            cbCarName = new ComboBox();
            groupBox1 = new GroupBox();
            rbhonda = new RadioButton();
            rbSubaru = new RadioButton();
            rbsuzuki = new RadioButton();
            rbOther = new RadioButton();
            rbNinsan = new RadioButton();
            rbToyota = new RadioButton();
            cbAuthor = new ComboBox();
            tbreport = new TextBox();
            dguRecord = new DataGridView();
            pbPicture = new PictureBox();
            btPIcOpen = new Button();
            btRecordDelete = new Button();
            btRecordadd = new Button();
            btRecordModify = new Button();
            btPicDelete = new Button();
            ofdPicFileOpen = new OpenFileDialog();
            btNewRecord = new Button();
            ssMessageArea = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            Collar = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            cdCollar = new ColorDialog();
            sfdReportfilesave = new SaveFileDialog();
            ofdReportFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dguRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ssMessageArea.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F);
            label1.Location = new Point(32, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 45);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F);
            label2.Location = new Point(211, 239);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F);
            label3.Location = new Point(59, 156);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F);
            label4.Location = new Point(59, 104);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 0;
            label4.Text = "記録者";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F);
            label5.Location = new Point(63, 217);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 0;
            label5.Text = "車名";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F);
            label6.Location = new Point(63, 278);
            label6.Name = "label6";
            label6.Size = new Size(83, 32);
            label6.TabIndex = 0;
            label6.Text = "レポート";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F);
            label7.Location = new Point(736, 30);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Yu Gothic UI", 28F);
            label8.Location = new Point(32, 363);
            label8.Name = "label8";
            label8.Size = new Size(98, 51);
            label8.TabIndex = 0;
            label8.Text = "一覧";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14F);
            dtpDate.Location = new Point(168, 40);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 32);
            dtpDate.TabIndex = 1;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14F);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(168, 220);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(200, 33);
            cbCarName.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbhonda);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbsuzuki);
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbNinsan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(156, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 49);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rbhonda
            // 
            rbhonda.AutoSize = true;
            rbhonda.Location = new Point(412, 13);
            rbhonda.Name = "rbhonda";
            rbhonda.Size = new Size(53, 19);
            rbhonda.TabIndex = 5;
            rbhonda.TabStop = true;
            rbhonda.Text = "ホンダ";
            rbhonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(212, 12);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 4;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbsuzuki
            // 
            rbsuzuki.AutoSize = true;
            rbsuzuki.Location = new Point(312, 12);
            rbsuzuki.Name = "rbsuzuki";
            rbsuzuki.Size = new Size(52, 19);
            rbsuzuki.TabIndex = 3;
            rbsuzuki.TabStop = true;
            rbsuzuki.Text = "スズキ";
            rbsuzuki.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(518, 13);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 2;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbNinsan
            // 
            rbNinsan.AutoSize = true;
            rbNinsan.Location = new Point(112, 13);
            rbNinsan.Name = "rbNinsan";
            rbNinsan.Size = new Size(49, 19);
            rbNinsan.TabIndex = 1;
            rbNinsan.TabStop = true;
            rbNinsan.Text = "日産";
            rbNinsan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(12, 13);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14F);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(168, 103);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(200, 33);
            cbAuthor.TabIndex = 2;
            // 
            // tbreport
            // 
            tbreport.Location = new Point(168, 278);
            tbreport.Multiline = true;
            tbreport.Name = "tbreport";
            tbreport.Size = new Size(510, 96);
            tbreport.TabIndex = 4;
            // 
            // dguRecord
            // 
            dguRecord.AllowUserToAddRows = false;
            dguRecord.AllowUserToDeleteRows = false;
            dguRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dguRecord.Location = new Point(73, 417);
            dguRecord.MultiSelect = false;
            dguRecord.Name = "dguRecord";
            dguRecord.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dguRecord.Size = new Size(931, 177);
            dguRecord.TabIndex = 5;
          //  dguRecord.CellContentClick += dguRecord_CellContentClick;
            dguRecord.Click += dguRecord_Click;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(736, 75);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(322, 258);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 6;
            pbPicture.TabStop = false;
            // 
            // btPIcOpen
            // 
            btPIcOpen.FlatStyle = FlatStyle.Flat;
            btPIcOpen.Location = new Point(877, 46);
            btPIcOpen.Name = "btPIcOpen";
            btPIcOpen.Size = new Size(75, 23);
            btPIcOpen.TabIndex = 7;
            btPIcOpen.Text = "開く....";
            btPIcOpen.UseVisualStyleBackColor = true;
            btPIcOpen.Click += btPIcOpen_Click_1;
            // 
            // btRecordDelete
            // 
            btRecordDelete.FlatStyle = FlatStyle.Flat;
            btRecordDelete.Location = new Point(983, 355);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(75, 48);
            btRecordDelete.TabIndex = 8;
            btRecordDelete.Text = "削除";
            btRecordDelete.UseVisualStyleBackColor = true;
            // 
            // btRecordadd
            // 
            btRecordadd.FlatStyle = FlatStyle.Flat;
            btRecordadd.Font = new Font("Yu Gothic UI", 12F);
            btRecordadd.Location = new Point(736, 355);
            btRecordadd.Name = "btRecordadd";
            btRecordadd.Size = new Size(75, 48);
            btRecordadd.TabIndex = 7;
            btRecordadd.Text = "追加";
            btRecordadd.UseVisualStyleBackColor = true;
            // 
            // btRecordModify
            // 
            btRecordModify.FlatStyle = FlatStyle.Flat;
            btRecordModify.Location = new Point(863, 355);
            btRecordModify.Name = "btRecordModify";
            btRecordModify.Size = new Size(75, 48);
            btRecordModify.TabIndex = 7;
            btRecordModify.Text = "修正";
            btRecordModify.UseVisualStyleBackColor = true;
            // 
            // btPicDelete
            // 
            btPicDelete.FlatStyle = FlatStyle.Flat;
            btPicDelete.Location = new Point(968, 46);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 8;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // btNewRecord
            // 
            btNewRecord.Location = new Point(446, 40);
            btNewRecord.Name = "btNewRecord";
            btNewRecord.Size = new Size(209, 90);
            btNewRecord.TabIndex = 9;
            btNewRecord.Text = "新規入力";
            btNewRecord.UseVisualStyleBackColor = true;
            btNewRecord.Click += btNewRecord_Click;
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            ssMessageArea.Location = new Point(0, 633);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(1099, 22);
            ssMessageArea.TabIndex = 10;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Collar, 開くToolStripMenuItem, 保存ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            ファイルFToolStripMenuItem.Click += ファイルFToolStripMenuItem_Click;
            // 
            // Collar
            // 
            Collar.Name = "Collar";
            Collar.Size = new Size(110, 22);
            Collar.Text = "色情報";
            Collar.Click += Collar_Click;
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(110, 22);
            開くToolStripMenuItem.Text = "開く";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(110, 22);
            保存ToolStripMenuItem.Text = "保存";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(155, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて";
            このアプリについてToolStripMenuItem.Click += このアプリについてToolStripMenuItem_Click;
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 655);
            Controls.Add(ssMessageArea);
            Controls.Add(menuStrip1);
            Controls.Add(btNewRecord);
            Controls.Add(btPicDelete);
            Controls.Add(btRecordDelete);
            Controls.Add(btRecordadd);
            Controls.Add(btRecordModify);
            Controls.Add(btPIcOpen);
            Controls.Add(pbPicture);
            Controls.Add(dguRecord);
            Controls.Add(tbreport);
            Controls.Add(groupBox1);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(dtpDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試験レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dguRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpDate;
        private ComboBox cbCarName;
        private GroupBox groupBox1;
        private RadioButton rbhonda;
        private RadioButton rbSubaru;
        private RadioButton rbsuzuki;
        private RadioButton rbOther;
        private RadioButton rbNinsan;
        private RadioButton rbToyota;
        private ComboBox cbAuthor;
        private TextBox tbreport;
        private DataGridView dguRecord;
        private PictureBox pbPicture;
        private Button btPIcOpen;
        private Button btRecordDelete;
        private Button btRecordadd;
        private Button btRecordModify;
        private Button btPicDelete;
        private OpenFileDialog ofdPicFileOpen;
        private Button btNewRecord;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tsslbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private ColorDialog cdCollar;
        private ToolStripMenuItem Collar;
        private SaveFileDialog sfdReportfilesave;
        private OpenFileDialog ofdReportFileOpen;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
    }
}
