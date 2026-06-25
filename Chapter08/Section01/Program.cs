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
            }
            while (true) {

                Console.WriteLine("******メニュー******");
                Console.WriteLine("1:一覧表示");
                Console.WriteLine("2:検索");
                Console.WriteLine("3:終了");
                Console.Write(">");
                var n = Console.ReadLine();
                if (n == "3") {
                    break;
                }
                switch (n) {
                    case "1":
                        foreach (var item in prefOfficeDict) {
                            Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
                        }
                        break;
                    case "2":
                        Console.WriteLine("都道府県：");
                        var search = Console.ReadLine();
                        var nu = prefOfficeDict[search];
                        Console.WriteLine(nu);
                        break;
                }
            }
        }
    }
}

