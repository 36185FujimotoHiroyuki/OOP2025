
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];

            Console.WriteLine("7.1.1");
            Exercise1(numbers);

            Console.WriteLine("7.1.2");
            Exercise2(numbers);

            Console.WriteLine("7.1.3");
            Exercise3(numbers);

            Console.WriteLine("7.1.4");
            Exercise4(numbers);

            Console.WriteLine("7.1.5");
            Exercise5(numbers);
        }
        private static void Exercise1(int[] numbers) {


            //int max = numbers.Max();
            Console.WriteLine(numbers.Max());
        }
        private static void Exercise2(int[] numbers) {
            //P169

            // var number 

            foreach (var number in numbers.TakeLast(2)) {

                Console.WriteLine(number);


            }
        }
        private static void Exercise3(int[] numbers) {

            // var number = new List<int>

            // Console.WriteLine(numbers.Select(numbers => numbers.ToString("0000")).ToArray();

            //正解
            var strs = numbers.Select(n => n.ToString("000"));
            foreach (var s in strs) {
                Console.WriteLine(s);
            }

           //ヒント見た
          // for(int i =0; i < numbers.Count(9); i++) {
          //      string num = numbers[i].ToString().PadLeft(3, '0');
           //     Console.WriteLine(num);
           // }
        }

        private static void Exercise4(int[] numbers) {
            //見た
            foreach (var number in numbers.Order().Take(3)) {

                Console.WriteLine(number);

            }
        }
        private static void Exercise5(int[] numbers) {

            var count = numbers.Distinct().Where(n => n >= 10).Count();

            Console.WriteLine(count);


        }
    }
}
