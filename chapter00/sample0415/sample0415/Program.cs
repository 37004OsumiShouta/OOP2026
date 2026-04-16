using System.Diagnostics.CodeAnalysis;

namespace sample0415
{
    internal class Program
    {
        static void Main(string[] args){
            int[] array = new int[10];
            //入力
            for (int i = 0; i < array.Length; i++){
                Console.Write("array[" + i + "] = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //集計
            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum = sum + array[i];
            //}

            Console.WriteLine();
            //出力
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[" + i + "]:");
                astOut(array[i]);
            }
            //合計
            Console.WriteLine("合計値：" + array.Where(n => n % 2 == 0).Sum()); //偶数だけ合計
        }
        static void astOut(int num){
            for (int j = 0; j < num; j++){
                Console.Write("*");
            }
            Console.WriteLine();  //改行
        }
    }
}

