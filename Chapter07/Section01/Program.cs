namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var books = Books.GetBooks();


            //①本の平均金額を表示
            //正しい
            Console.WriteLine((int)books.Average(x => x.Price));

            // Console.WriteLine(books);

            //②本のページ合計を表示
            //正しい
            Console.WriteLine((int)books.Sum(x => x.Pages));

            //
            //③金額の安い書籍名と金額を表示
            //正しい
            var hon = books.Where(x => x.Price == books.Min(b => b.Price));
            foreach(var item in hon) {
             Console.WriteLine(item.Title + ":" + item.Price);
            }
         
            //④ページが多い書籍名とページ数を表示
            books.Where(x=>x.Pages == books
                .Max(b => b.Pages)) .ToList()
                .ForEach(x => Console.WriteLine($"{x.Title} : {x.Pages}ページ"));





            // var bookWithMostPages = books.OrderByDescending(book => book.Pages).FirstOrDefault();
            // if (bookWithMostPages != null) {
            //     Console.WriteLine($"最もページ数が多い書籍: {bookWithMostPages.Title} - ページ数: {bookWithMostPages.Pages}ページ");
            //} else {
            //     Console.WriteLine("書籍がありません。");
            // } 


            //⑤タイトルに「物語」が含まれている書籍名をすべて表示

            var titles = books.Where(x => x.Title.Contains("物語"));
              
                    foreach (var item in titles) {
                Console.WriteLine(item.Title);
                        // Console.WriteLine($"書籍名: {book.Title} - 価格: {book.Price:C} - ページ数: {book.Pages}ページ");

                    }
                }
            }
        }
    

        
    

