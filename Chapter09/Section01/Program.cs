using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {


            //[基本]
            //     var today = DateTime.Today;//日付

            //     var now = DateTime.Now;    //日付と時刻


            //    Console.WriteLine($"Today:{ today}");

            //   Console.WriteLine($"Now:{now}");
            //」





            //[ステップ１]
            //  var today = new DateTime(2005,12,20);//日付

            //  var now = DateTime.Now;//日付と時刻

            //  Console.WriteLine($"Today:{today.Month}");

            //  Console.WriteLine($"Now:{now}");

            //」




            //①[自分の生年月日は何曜日かをプログラムを書いて調べる]

            Console.Write("西暦：");
            var year = int.Parse(Console.ReadLine());

            Console.Write("西暦：");
            var month = int.Parse(Console.ReadLine());

            Console.Write("西暦：");
            var day = int.Parse(Console.ReadLine());

            var birth = new DateTime(year, month, day);

            var colture = new CultureInfo("ja-JP");


            //  var today =  new DateTime(2005, 12, 20);

            //   DayOfWeek DayOfWeek = today.DayOfWeek;
            //      if (DayOfWeek == DayOfWeek.Tuesday) {
            //         Console.WriteLine("火曜日です");
            //    } else {
            //        Console.WriteLine($"2005/12/20 は {today.DayOfWeek} でした");
            //    }

            //   }
            //」


            //②うるう年
            Console.WriteLine("何年か入力");
            Console.ReadLine();

              var isLeapYear = DateTime.IsLeapYear(2024);

                if (isLeapYear) {

                  Console.WriteLine("閏年です");
               } else {
                  Console.WriteLine("閏年ではありません");
              }

            //③[生まれてから何日たったか]


            var seinenn = new DateTime(2005, 12, 20);


            var today = DateTime.Today;


            var ikitahi = (today - seinenn).Days;// 経過日数を計算


            Console.WriteLine($"生まれてから {ikitahi} 日目です。");



        }
        }
    }


