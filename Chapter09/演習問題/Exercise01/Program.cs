using System.Globalization;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var dateTime = DateTime.Now;
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
           
            var dt = new DateTime(2024, 3, 9, 19, 3, 9);

            Console.WriteLine(dt.ToString("yyyy/MM/dd HH:mm"));
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            //DateTime.ToStringを使った例

            var dt = new DateTime(2024, 3, 9, 19, 3, 9);
             Console.WriteLine(dt.ToString("yyyy年MM月dd日　HH時mm分ss秒"));
          
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            var dt = new DateTime(2024, 3, 9, 19, 3, 9);
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
               Console.WriteLine(dt.ToString("ggy年M月d日(dddd)", culture));
        }
    }
    }


