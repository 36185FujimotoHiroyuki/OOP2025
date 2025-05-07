namespace StopWatch {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbTimeDisp = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tmDispTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTimeDisp
            // 
            this.lbTimeDisp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTimeDisp.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimeDisp.Location = new System.Drawing.Point(12, 22);
            this.lbTimeDisp.Name = "lbTimeDisp";
            this.lbTimeDisp.Size = new System.Drawing.Size(285, 54);
            this.lbTimeDisp.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(20, 101);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(121, 54);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(85, 172);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(121, 54);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(159, 101);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(121, 54);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            // 
            // tmDispTimer
            // 
            this.tmDispTimer.Tick += new System.EventHandler(this.tmDispTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(314, 280);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.lbTimeDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimeDisp;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Timer tmDispTimer;
    }
}

