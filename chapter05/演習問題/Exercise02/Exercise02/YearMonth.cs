

namespace Exercise02 {
    internal class YearMonth {
        private int v1;
        private int v2;

        public YearMonth(int v1, int v2) {
            this.v1 = v1;
            this.v2 = v2;
        }

        public bool Is21Century { get; internal set; }
        public string Year { get; internal set; }

        internal object AddOneMonth() {
            throw new NotImplementedException();
        }
    }
    }