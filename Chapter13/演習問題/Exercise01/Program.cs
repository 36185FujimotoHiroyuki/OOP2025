
using System.Text.RegularExpressions;

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
            .Join(Library.Categories,
                  book => book.CategoryId,
                  category => category.Id,
                  (book, category) => category.Name)
            .Distinct();
            foreach (var category in Books) {
                Console.WriteLine(category);
            }


        }

        private static void Exercise1_6() {

            var booksCategory = Library.Books
           .Join(Library.Categories,
                 book => book.CategoryId,
                 category => category.Id,
                 (book, category) => new { book, category.Name })
           .GroupBy(b => b.Name)
           .OrderBy(g => g.Key);

            foreach (var categoryGroup in booksCategory) {
                Console.WriteLine($"# {categoryGroup.Key}");
                foreach (var book in categoryGroup) {
                    Console.WriteLine($"  {book.book.Title}");
                }
            }
        }

        private static void Exercise1_7() {


            var booksCategory = Library.Books

           .Join(Library.Categories,
                 book => book.CategoryId,
                 category => category.Id,
                 (book, category) => new { book, category.Name })

                    .Where(b => b.Name == "Development")
               .OrderBy(b => b.book.Title);

            foreach (var item in booksCategory) {
                Console.WriteLine($"# {item.Name}");
                Console.WriteLine($"  {item.book.Title}");

            }
        }

        private static void Exercise1_8() {


            var categoryNames = Library.Categories
        .GroupJoin(Library.Books,
            c => c.Id,
            b => b.CategoryId,
            (c, books) => new {
                CategoryName = c.Name, 
                Count = books.Count()   
            })
        .Where(x => x.Count >= 4)   
        .Select(x => x.CategoryName);

            foreach (var name in categoryNames) 
            {
                Console.WriteLine(name);





            }
        }
    }
}
