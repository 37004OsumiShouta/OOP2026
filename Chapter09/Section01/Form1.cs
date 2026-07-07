using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)nudDay.Value).ToString();
        }
        private void btBirthCalc_Click_1(object sender, EventArgs e) {
            DateTime birth = dtpBirth.Value;
            DateTime today = DateTime.Today;
            int age = today.Year - birth.Year;
            if (today < birth.AddYears(age)) {
                age--;
            }
            tbOut.Text = $"‚ ‚È‚½‚Í{age}Î‚Å‚·";
            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"¶‚Ü‚ê‚Ä‚©‚ç{ts.Days}“ú–Ú‚Å‚·B";
        }
    }
}
