namespace CarReportSystem {
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
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cbCarName = new ComboBox();
            rbToyota = new RadioButton();
            rbNissan = new RadioButton();
            rbHonda = new RadioButton();
            rbSubaru = new RadioButton();
            rbInport = new RadioButton();
            rbOther = new RadioButton();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cbAuthor = new ComboBox();
            label5 = new Label();
            tbReport = new TextBox();
            dgvRecords = new DataGridView();
            label6 = new Label();
            btNewInput = new Button();
            label7 = new Label();
            btOpenPicture = new Button();
            btDeletePicture = new Button();
            pbPicture = new PictureBox();
            btAddRecord = new Button();
            btModifyRecord = new Button();
            btDeleteRecord = new Button();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            ファイルFToolStripMenuItem1 = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            ofdPicFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(125, 30);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(13, 159);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(13, 218);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 0;
            label3.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(125, 215);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(216, 40);
            cbCarName.TabIndex = 2;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(6, 23);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 3;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(62, 22);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 3;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(117, 22);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 3;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(176, 22);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbInport
            // 
            rbInport.AutoSize = true;
            rbInport.Location = new Point(236, 22);
            rbInport.Name = "rbInport";
            rbInport.Size = new Size(61, 19);
            rbInport.TabIndex = 3;
            rbInport.TabStop = true;
            rbInport.Text = "輸入車";
            rbInport.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(303, 22);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 3;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbInport);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Location = new Point(125, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 48);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(13, 109);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 0;
            label4.Text = "記録者";
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(125, 101);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(216, 40);
            cbAuthor.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(16, 291);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // tbReport
            // 
            tbReport.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbReport.Location = new Point(125, 291);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(373, 123);
            tbReport.TabIndex = 5;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(125, 461);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.Size = new Size(474, 288);
            dgvRecords.TabIndex = 6;
            dgvRecords.Click += dgvRecords_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(30, 461);
            label6.Name = "label6";
            label6.Size = new Size(62, 32);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // btNewInput
            // 
            btNewInput.BackColor = Color.PaleTurquoise;
            btNewInput.FlatStyle = FlatStyle.Flat;
            btNewInput.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNewInput.Location = new Point(372, 28);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(126, 39);
            btNewInput.TabIndex = 7;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            btNewInput.Click += btNewInput_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(562, 30);
            label7.Name = "label7";
            label7.Size = new Size(62, 32);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // btOpenPicture
            // 
            btOpenPicture.BackColor = Color.PaleGreen;
            btOpenPicture.FlatStyle = FlatStyle.Flat;
            btOpenPicture.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btOpenPicture.Location = new Point(648, 21);
            btOpenPicture.Name = "btOpenPicture";
            btOpenPicture.Size = new Size(117, 39);
            btOpenPicture.TabIndex = 8;
            btOpenPicture.Text = "開く...";
            btOpenPicture.UseVisualStyleBackColor = false;
            btOpenPicture.Click += btOpenPicture_Click;
            // 
            // btDeletePicture
            // 
            btDeletePicture.BackColor = SystemColors.ActiveCaptionText;
            btDeletePicture.FlatStyle = FlatStyle.Flat;
            btDeletePicture.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeletePicture.ForeColor = SystemColors.ControlLightLight;
            btDeletePicture.Location = new Point(792, 21);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(117, 39);
            btDeletePicture.TabIndex = 9;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = false;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(562, 73);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(505, 382);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 10;
            pbPicture.TabStop = false;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = SystemColors.ActiveCaption;
            btAddRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddRecord.ForeColor = SystemColors.ActiveCaptionText;
            btAddRecord.Location = new Point(648, 461);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(81, 81);
            btAddRecord.TabIndex = 11;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btModifyRecord
            // 
            btModifyRecord.BackColor = SystemColors.Info;
            btModifyRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyRecord.Location = new Point(802, 461);
            btModifyRecord.Name = "btModifyRecord";
            btModifyRecord.Size = new Size(81, 81);
            btModifyRecord.TabIndex = 12;
            btModifyRecord.Text = "修正";
            btModifyRecord.UseVisualStyleBackColor = false;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.Black;
            btDeleteRecord.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteRecord.ForeColor = SystemColors.ControlLightLight;
            btDeleteRecord.Location = new Point(966, 461);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(81, 81);
            btDeleteRecord.TabIndex = 13;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1229, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem1, 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // ファイルFToolStripMenuItem1
            // 
            ファイルFToolStripMenuItem1.Name = "ファイルFToolStripMenuItem1";
            ファイルFToolStripMenuItem1.Size = new Size(155, 22);
            ファイルFToolStripMenuItem1.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(155, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(155, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(152, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(155, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(152, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(155, 22);
            終了ToolStripMenuItem.Text = "終了(&X)";
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
            このアプリについてToolStripMenuItem.Size = new Size(164, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            statusStrip1.Location = new Point(0, 796);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1229, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 818);
            Controls.Add(statusStrip1);
            Controls.Add(btDeleteRecord);
            Controls.Add(btModifyRecord);
            Controls.Add(btAddRecord);
            Controls.Add(pbPicture);
            Controls.Add(btDeletePicture);
            Controls.Add(btOpenPicture);
            Controls.Add(btNewInput);
            Controls.Add(dgvRecords);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private ComboBox cbCarName;
        private RadioButton rbToyota;
        private RadioButton rbNissan;
        private RadioButton rbHonda;
        private RadioButton rbSubaru;
        private RadioButton rbInport;
        private RadioButton rbOther;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cbAuthor;
        private Label label5;
        private TextBox tbReport;
        private DataGridView dgvRecords;
        private Label label6;
        private Button btNewInput;
        private Label label7;
        private Button btOpenPicture;
        private Button btDeletePicture;
        private PictureBox pbPicture;
        private Button btAddRecord;
        private Button btModifyRecord;
        private Button btDeleteRecord;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem ファイルFToolStripMenuItem1;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslbMessage;
        private OpenFileDialog ofdPicFileOpen;
    }
}
