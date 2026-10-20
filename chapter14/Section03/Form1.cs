using System.Diagnostics;
using System.Threading.Tasks;

namespace Section03 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e) {
            //Thread.Sleep(5000);
            //MessageBox.Show("Š®—¹");

            //await Task.Delay(5000);
            //MessageBox.Show("Š®—¹");

            var elapsed = await DoLongTimeWorkAsync(5000);
            MessageBox.Show(elapsed + "ƒ~ƒŠ•b");
        }
        //–ß‚è’l‚È‚µ
        private async Task DoLongTimeWorkAsync() {
            await Task.Run(() => {
                Thread.Sleep(2500);
            });
        }
        //–ß‚è’l‚ ‚è
        private async Task<long> DoLongTimeWorkAsync(int milliseconds) {
            var sw = Stopwatch.StartNew();
            await Task.Run(() => {
                Thread.Sleep(2500);
            });
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
