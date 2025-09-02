namespace RssReader {
    partial class btGobak {
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
            tbURL = new TextBox();
            btRssGet = new Button();
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            btGoBack = new Button();
            button2 = new Button();
            btnAddFavorite = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // tbURL
            // 
            tbURL.Font = new Font("Yu Gothic UI", 20F);
            tbURL.Location = new Point(291, 25);
            tbURL.Name = "tbURL";
            tbURL.Size = new Size(588, 43);
            tbURL.TabIndex = 0;
            tbURL.TextChanged += tbURL_TextChanged;
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 20F);
            btRssGet.Location = new Point(944, 12);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(161, 60);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.Font = new Font("Yu Gothic UI", 18F);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 32;
            lbTitles.Location = new Point(47, 135);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(1058, 164);
            lbTitles.TabIndex = 2;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(47, 305);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(1058, 294);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            // 
            // btGoBack
            // 
            btGoBack.Font = new Font("Yu Gothic UI", 20F);
            btGoBack.Location = new Point(47, 21);
            btGoBack.Name = "btGoBack";
            btGoBack.Size = new Size(93, 51);
            btGoBack.TabIndex = 4;
            btGoBack.Text = "戻る";
            btGoBack.UseVisualStyleBackColor = true;
            btGoBack.Click += btGoBack_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 20F);
            button2.Location = new Point(163, 21);
            button2.Name = "button2";
            button2.Size = new Size(100, 51);
            button2.TabIndex = 5;
            button2.Text = "進む";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAddFavorite
            // 
            btnAddFavorite.Font = new Font("Yu Gothic UI", 12F);
            btnAddFavorite.Location = new Point(944, 87);
            btnAddFavorite.Name = "btnAddFavorite";
            btnAddFavorite.Size = new Size(161, 42);
            btnAddFavorite.TabIndex = 6;
            btnAddFavorite.Text = "お気に入り登録";
            btnAddFavorite.UseVisualStyleBackColor = true;
            btnAddFavorite.Click += btnAddFavorite_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 12F);
            textBox1.Location = new Point(291, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(588, 29);
            textBox1.TabIndex = 7;
            // 
            // btGobak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1162, 611);
            Controls.Add(textBox1);
            Controls.Add(btnAddFavorite);
            Controls.Add(button2);
            Controls.Add(btGoBack);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Controls.Add(tbURL);
            Name = "btGobak";
            Text = "RssReader";
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbURL;
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button btGoBack;
        private Button button2;
        private Button btnAddFavorite;
        private TextBox textBox1;
    }
}
