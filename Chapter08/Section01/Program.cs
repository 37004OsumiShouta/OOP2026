using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Markup;

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
                var m = pref;
                if (prefOfficeDict.ContainsKey(m)) {
                    Console.WriteLine("上書きしますか？(Y/N)");
                    var n = Console.ReadLine();
                    if (n is "Y") {
                        prefOfficeDict[pref] = prefCaptalLocation;
                    }
                } else {
                    prefOfficeDict.Add(pref, prefCaptalLocation);
                    Console.WriteLine();
                }
                Boolean endFlag = false;           //終了フラグ（メニューの無限ループを抜けるため）
                while (!endFlag) {
                    switch (menuDisp()) {
                        case 1:
                            aliDisp();
                            break;
                        case 2:
                            searchPrefCaptalLocation();
                            break;
                        default:
                            endFlag = true;
                            break;
                    }
                }
            }
        }

        private static int menuDisp() {
            //メニュー表示
            Console.WriteLine("\n***メニュー***");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("3:終了");
            Console.Write(">");
            //メニュー番号を入力させて呼び出し元へ返却
            var menuSelect = int.Parse(Console.ReadLine());
            return menuSelect;
        }

        //一覧表示処理
        private static void aliDisp() {
            foreach (var p in prefOfficeDict) {
                Console.WriteLine($"{p.Key}の県庁所在地は{p.Value}です。");
            }
        }
        //検索処理
        private static void searchPrefCaptalLocation() {
            Console.WriteLine("都道府県:");
            var serchPref = Console.ReadLine();
            if (serchPref is null) return;

            //検索した結果を表示
            if (prefOfficeDict.ContainsKey(serchPref)) {
                Console.WriteLine($"{serchPref}の県庁所在地は{serchPref}です。");
            }
        }
    }
}


