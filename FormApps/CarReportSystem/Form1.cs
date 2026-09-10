using SQLiteProductSample;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        CarReportRepository repository = new CarReportRepository();

        //設定クラスのオブジェクトを生成

        //Settings settings = Settings.Instance;

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                Settings.Instance.Load();
                BackColor = Color.FromArgb(Settings.Instance.MainFormBackColor);

                listCarReports.Clear();

                foreach (var report in CarReportRepository.GetAll()) {
                    listCarReports.Add(report);
                }
            }
            catch (Exception ex) {
                tsslbMessage.Text = "設定ファイル読み込みエラー";
                MessageBox.Show(ex.Message);
            }
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMessage.Text = String.Empty;  //メッセージ領域のクリア


            //*****************************
            //ここに記録者と車名が未入力だった場合の処理を記述する
            if (cbAuthor.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }
            //*****************************

            var carReport = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text.Trim(),
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            carReport.Id = repository.Add(carReport);
            
            listCarReports.Add(carReport);
            //入力履歴を登録
            SetCbAutor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.CurrentRow.Selected = false;
            InputItemsUpdate();
        }
        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;

            if (rbNissan.Checked)
                return MakerGroup.ニッサン;

            if (rbHonda.Checked)
                return MakerGroup.ホンダ;

            if (rbSubaru.Checked)
                return MakerGroup.スバル;

            if (rbInport.Checked)
                return MakerGroup.輸入車;
            return MakerGroup.その他;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e) {

        }

        private void btOpenPicture_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }
        private void btNewInput_Click(object sender, EventArgs e) {
            InputItemsAllClear();
        }
        private void InputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            rbOther.Checked = true;
            pbPicture.Image = null;
            dgvRecords.ClearSelection(); //セルの選択を解除する
            cbAuthor.Items.Clear();
            cbCarName.Items.Clear();
        }
        private void SetRadioButtonMaker(MakerGroup targetMaker) {
            switch ((targetMaker)) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.ニッサン:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbInport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //記録者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAutor(string autor) {
            if (!cbAuthor.Items.Contains(autor))
                cbAuthor.Items.Add(autor);
        }

        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName) {
            //未登録なら登録
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //選択されているインデックスを取得
        private void btDeleteRecord_Click(object sender, EventArgs e) {
            // 選択されている行からCarReportを取得
            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "削除するレポートを選択してください";
                return;
            }

            try {
                // SQLiteから削除
                repository.Delete(carReport);

                // Form1のリストから削除
                listCarReports.Remove(carReport);

                // 入力欄をクリア
                InputItemsAllClear();

                tsslbMessage.Text = "レポートを削除しました。";
            }
            catch (Exception ex) {
                tsslbMessage.Text = "削除エラー";
                MessageBox.Show(ex.Message);

                InputItemsUpdate();
            }
        }

        private void InputItemsUpdate() {
            if (dgvRecords.CurrentRow is null || !dgvRecords.CurrentRow.Selected)
                InputItemsAllClear();
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {
            if (dgvRecords.SelectedRows.Count == 0) {
                tsslbMessage.Text = "修正するレポートを選択してください";
            }
            if (String.IsNullOrWhiteSpace(cbAuthor.Text)
                || String.IsNullOrWhiteSpace(cbCarName.Text)) {
                tsslbMessage.Text = "記録者，または車名が未入力です";
            }

            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            //カーレポート管理用リストの該当する要素のデータを書き換える
            carReport.Date = dtpDate.Value.Date;
            carReport.Author = cbAuthor.Text.Trim();
            carReport.Maker = GetRadioButtonMaker();
            carReport.CarName = cbCarName.Text.Trim();
            carReport.Report = tbReport.Text;
            carReport.Picture = pbPicture.Image;

            repository.Update(carReport);

            dgvRecords.Refresh();

            SetCbAutor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());


            dgvRecords.Refresh();
            tsslbMessage.Text = "レポートを修正しました。";
        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e) {
            if ((dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
                 || (!dgvRecords.CurrentRow.Selected)) return;

            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = (carReport.Picture);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;

                Settings.Instance.MainFormBackColor = cdColor.Color.ToArgb();
            }
        }
        //フォームを閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理（シリアル化）
            //P283以降を参考にする（ファイル名：setting.xml)
            Settings.Instance.Save();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }
        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            reportOpenFile();
        }

        //ファイルセーブ処理
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        sfdReportFileSave.FileName,
                        FileMode.Create
                        )) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void reportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open(
                        ofdReportFileOpen.FileName,
                        FileMode.Open,
                        FileAccess.Read
                        )) {
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecords.DataSource = listCarReports;
                    }
                    //コンボボックスの履歴をすべて消す
                    cbAuthor.Items.Clear();
                    cbCarName.Items.Clear();
                    //コンボボックスの履歴を再登録
                    foreach (var report in listCarReports) {
                        SetCbAutor(report.Author);
                        SetCbCarName(report.CarName);
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pbPicture_Click(object sender, EventArgs e) {

        }
    }
}
