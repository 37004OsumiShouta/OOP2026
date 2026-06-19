namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            var books = Books.GetBooks();
            var average = books.Average(x => x.Price);
            var pageAverage = books.Sum(y => y.Pages);
            var maxPrice = books.Max(z => z.Price);

            Console.WriteLine("平均金額:" + average);
            Console.WriteLine("合計ページ:" + pageAverage);
            Console.WriteLine("高価な本:" + maxPrice);

            Console.WriteLine("--- 500円以上の本 ---");
            var price = books.Where(a => a.Price >= 500);
            foreach (var item in price) {
                Console.WriteLine(item.Title);


            }
            //250ページ以上の本を上位3冊出力
            Console.WriteLine("---250ページ以上の本を３冊---");
            var page = books.Where(a => a.Pages >= 250).Take(3);
            foreach (var book in page) {
                Console.WriteLine(book.Title);
            }
        }
    }
}
