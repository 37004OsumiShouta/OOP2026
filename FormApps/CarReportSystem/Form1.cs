using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }
        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMessage.Text = String.Empty;  //メッセージ領域のクリア

            //*****************************
            //ここに記録者と車名が未入力だった場合の処理を記述する
            if (cbAuthor.Text == String.Empty && cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;

            }
            //*****************************

            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,



            };
            listCarReports.Add(carReport);
            SetCbAutor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);
            ImputItemsAllClear();
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
            ImputItemsAllClear();
        }

        private void ImputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            rbOther.Checked = true;
            pbPicture.Image = null;
        }


        private void dgvRecords_Click(object sender, EventArgs e) {

            if (dgvRecords.CurrentRow is null) return;

            dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            SetRadioButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
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
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
    