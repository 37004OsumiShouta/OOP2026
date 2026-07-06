namespace Section01 {
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
            ofdOpen = new OpenFileDialog();
            dtpDate = new DateTimePicker();
            btGet = new Button();
            tbOut = new TextBox();
            SuspendLayout();
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(22, 26);
            dtpDate.Margin = new Padding(6);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(368, 39);
            dtpDate.TabIndex = 0;
            // 
            // btGet
            // 
            btGet.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGet.Location = new Point(460, 26);
            btGet.Margin = new Padding(6);
            btGet.Name = "btGet";
            btGet.Size = new Size(158, 39);
            btGet.TabIndex = 1;
            btGet.Text = "取得";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(27, 110);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(447, 39);
            tbOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2004, 1250);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpDate);
            Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut;
    }
}
