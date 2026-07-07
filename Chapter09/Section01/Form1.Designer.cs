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
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpBirth = new DateTimePicker();
            label2 = new Label();
            tbOut2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btBirthCalc = new Button();
            tbOut3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
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
            btGet.Location = new Point(402, 26);
            btGet.Margin = new Padding(6);
            btGet.Name = "btGet";
            btGet.Size = new Size(158, 39);
            btGet.TabIndex = 1;
            btGet.Text = "計算";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(608, 144);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(447, 39);
            tbOut.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Location = new Point(22, 117);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(320, 39);
            nudDay.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 124);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpBirth
            // 
            dtpBirth.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirth.Location = new Point(608, 54);
            dtpBirth.Margin = new Padding(6);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(368, 39);
            dtpBirth.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 16);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 4;
            label2.Text = "生年月日";
            // 
            // tbOut2
            // 
            tbOut2.Location = new Point(608, 261);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(447, 39);
            tbOut2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(608, 109);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 4;
            label3.Text = "年齢";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 226);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 4;
            label4.Text = "経過日数";
            // 
            // btBirthCalc
            // 
            btBirthCalc.Location = new Point(999, 51);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(109, 42);
            btBirthCalc.TabIndex = 5;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = true;
            btBirthCalc.Click += btBirthCalc_Click_1;
            // 
            // tbOut3
            // 
            tbOut3.Location = new Point(608, 362);
            tbOut3.Multiline = true;
            tbOut3.Name = "tbOut3";
            tbOut3.Size = new Size(447, 160);
            tbOut3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(608, 226);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 4;
            label5.Text = "経過日数";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(608, 226);
            label6.Name = "label6";
            label6.Size = new Size(110, 32);
            label6.TabIndex = 4;
            label6.Text = "経過日数";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(608, 226);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 4;
            label7.Text = "経過日数";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(608, 226);
            label8.Name = "label8";
            label8.Size = new Size(110, 32);
            label8.TabIndex = 4;
            label8.Text = "経過日数";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(608, 327);
            label9.Name = "label9";
            label9.Size = new Size(49, 32);
            label9.TabIndex = 4;
            label9.Text = "メモ";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2004, 1250);
            Controls.Add(btBirthCalc);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut3);
            Controls.Add(tbOut2);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpBirth);
            Controls.Add(dtpDate);
            Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dtpBirth;
        private Label label2;
        private TextBox tbOut2;
        private Label label3;
        private Label label4;
        private Button btBirthCalc;
        private TextBox tbOut3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
