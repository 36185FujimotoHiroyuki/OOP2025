namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var books = Library.Books
       //var price = Library.Books
       //    .Where(b => b.CategoryId == 1)
       //     .Max(b => b.Price);
       // Console.WriteLine(price);

            //  Console.WriteLine();//改行
            //  var book = Library.Books
            //    .Where(b => b.PublishedYear >= 2021)
            ////     .MinBy(b => b.Price);
            // Console.WriteLine(book);
            // Console.WriteLine();//改行

            //var average = Library.Books.Average(x => x.Price);
            // var aboves = Library.Books
            //    .Where(b => b.Price > average);
            //foreach (var book1 in aboves) {
            //    Console.WriteLine(book1);

            //      var selected = Library.Books
            // .GroupBy(b => b.PublishedYear)
            //  .Select(group => group.MaxBy(b => b.Price))
            // .OrderBy(b => b!.PublishedYear);

            //    foreach (var book in selected) {
            //        Console.WriteLine($"{book!.PublishedYear}年 {book!.Title} ({book!.Price})");



      private static void Exercise1_7() {
            var books = Library.Books
                .Join(Library.Categories,                    // JoinでBooksとCategoriesを結合
                      book => book.CategoryId,               // 結合条件：BookのCategoryId
                      category => category.Id,              // 結合条件：CategoryのId
                      (book, category) => new {             // 結合後に新しい匿名型を作成
                          book.Title,                       // タイトル
                          CategoryName = category.Name,     // カテゴリ名
                          book.PublishedYear                // 発行年
                      })
            .OrderBy(b => b.PublishedYear)
                .ThenBy(b => b.Category);
            // 結果をコンソールに出力
            foreach (var book in books) {
                Console.WriteLine($"{book.Title} ({book.Category}, {book.PublishedYear}年)");



            }
        }
    }
}



