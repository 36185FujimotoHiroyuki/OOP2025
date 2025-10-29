
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            // var expensiveBooks = Library.Books.Where(b => b.Price == maxPrice);

            var book = Library.Books.MaxBy(book => book.Price);
            Console.WriteLine(book);

        }

        private static void Exercise1_3() {
            var countsByYear = Library.Books
                 //  .GroupBy(book => book.PublishedYear)      
                 // .Select(group => new { Year = group.Key, Count = group.Count() }) 
                 // .OrderBy(group => group.Year);               

                 // foreach (var item in countsByYear) {
                 //    Console.WriteLine($"{item.Year}年: {item.Count}");


                 .GroupBy(b => b.PublishedYear)
                  .OrderBy(b => b.Key)
                  .Select(b => new {
                      PublishedYear = b.Key,
                      Count = b.Count()
                  });
            foreach (var item in countsByYear) {
                Console.WriteLine($"{item.PublishedYear}年: {item.Count}");


            }
        }
        private static void Exercise1_4() {
            var Books = Library.Books
           
            .OrderByDescending(b => b.PublishedYear)
            .ThenByDescending(b => b.Price);

            foreach (var book in Books) {
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title}");

            }

        }
        private static void Exercise1_5() {

            var Books = Library.Books
       .Where(book => book.PublishedYear == 2022)
       .Select(book => book.CategoryId)
       .Distinct()
       .OrderBy(category => category);
      

            foreach (var category in Books) {
                Console.WriteLine(category);
            }


        }

        private static void Exercise1_6() {

        }

        private static void Exercise1_7() {

        }

        private static void Exercise1_8() {

        }
    }
}
