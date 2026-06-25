using System.Runtime.Serialization;

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptalLocation;
            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");

            while (true) {
                //1 都道府県の入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();
                if (pref == null) break;   //無限ループを抜ける(Ctrl + Z)

                //2 県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();

                //3 県庁所在地登録処理
                prefOfficeDict.Add(pref, prefCaptalLocation);
                Console.WriteLine("******メニュー******");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("3:終了");
                Console.WriteLine(">");
                var n = Console.ReadLine();
                if (n == "3") {
                    break;
                }
                switch (n) {
                    case 
                foreach (var item in prefOfficeDict) {
                    Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");

                }
            }
        }
    }
}

