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
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            var dayOfWeek = culture.DateTimeFormat.GetDayName(birth.DayOfWeek);
            if (today < birth.AddYears(age)) {
                age--;

            }
            tbOut.Text = $"あなたは{age}歳です";
            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"生まれてから{ts.Days}日目です。";
            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は第{NthWeek(birth)}週の{dayOfWeek}です。";
            ////年齢を求めるメソッド
            //static int GetAge(DateTime birthday, DateTime targetDay) {
            //    var age = targetDay.Year - birthday.Year;
            //    if (targetDay < birthday.AddYears(age)) {
            //        age--;

            //    }
            //    return age;

            static int NthWeek(DateTime date) {
                var firstDay = new DateTime(date.Year, date.Month, 1);
                var firstDayOfWeek = (int)(firstDay.DayOfWeek);
                return (date.Day + firstDayOfWeek - 1) / 7 + 1;
            }

            DateTime nextBirthday = new DateTime(today.Year, birth.Month, birth.Day);
            if (nextBirthday < today.Date) {
                nextBirthday = nextBirthday.AddYears(1);
            }
            var span = nextBirthday - today;

            if (span.Days == 0) {
                tbOut4.Text = "誕生日は今日です";
            } else {
                tbOut4.Text = $"誕生日まであと{span.Days}日です。";
            }
        }


        private void label9_Click(object sender, EventArgs e) {

        }
    }
}
