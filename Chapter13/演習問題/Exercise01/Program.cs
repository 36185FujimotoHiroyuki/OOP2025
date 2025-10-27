
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
            
            var book = Library.Books.Max(b => b.Price);
            Console.WriteLine(book);
         
        }

        private static void Exercise1_3() {
            var countsByYear = Library.Books
       .GroupBy(b => b.PublishedYear)      
       .Select(g => new { Year = g.Key, Count = g.Count() }) 
       .OrderBy(g => g.Year);               

            foreach (var item in countsByYear) {
                Console.WriteLine($"{item.Year}年: {item.Count}");
            }
        }
        private static void Exercise1_4() {
          
        }

        private static void Exercise1_5() {
      
        }

        private static void Exercise1_6() {
   
        }

        private static void Exercise1_7() {
          
        }

        private static void Exercise1_8() {
        
        }
    }
}
