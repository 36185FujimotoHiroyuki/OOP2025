namespace UnitConverter {
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
            tbBeforeConversion = new TextBox();
            tbAfterConversion = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(82, 46);
            label1.Name = "label1";
            label1.Size = new Size(218, 45);
            label1.TabIndex = 0;
            label1.Text = "距離換算アプリ";
            // 
            // tbBeforeConversion
            // 
            tbBeforeConversion.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbBeforeConversion.Location = new Point(103, 130);
            tbBeforeConversion.Name = "tbBeforeConversion";
            tbBeforeConversion.Size = new Size(173, 39);
            tbBeforeConversion.TabIndex = 1;
            tbBeforeConversion.TextChanged += tbBeforeConversion_TextChanged;
            // 
            // tbAfterConversion
            // 
            tbAfterConversion.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbAfterConversion.Location = new Point(103, 316);
            tbAfterConversion.Name = "tbAfterConversion";
            tbAfterConversion.Size = new Size(173, 39);
            tbAfterConversion.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(103, 208);
            button1.Name = "button1";
            button1.Size = new Size(173, 46);
            button1.TabIndex = 2;
            button1.Text = "変換";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ConvertButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(511, 346);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 444);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbAfterConversion);
            Controls.Add(tbBeforeConversion);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbBeforeConversion;
        private TextBox tbAfterConversion;
        private Button button1;
        private Button button2;
    }
}
