using System.Configuration;
using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            DateTime date = DateTime.Now;
            tbOut1.Text = date.ToString("yyyy/MM/dd HH:ss");

        }
        private void btButton2_Click(object sender, EventArgs e) {
            DateTime date = DateTime.Now;
            var s1 = date.ToString("yyyy”NMMŒŽdd“ú HHŽžmm•ªss•b");
            tbOut2.Text = s1;
        }

        private void btButton3_Click(object sender, EventArgs e) {
            DateTime date = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = date.ToString("gg y”N MŒŽ d“ú(dddd)", culture);
            tbOut3.Text = str;
        }
    }
}
