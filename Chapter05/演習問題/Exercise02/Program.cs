using Exercise01;

namespace Exercise02 {
    public class Program {
        static void Main(string[] args) {
           // Exercise01.YearMonth;
            //２番
            // 5.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2024, 12),
            };

            Console.WriteLine("5.2.2");
            Exercise2(ymCollection);

            Console.WriteLine("5.2.4");
            Exercise4(ymCollection);


            Console.WriteLine("5.2.5");
            Exercise5(ymCollection);
        }

        private static void Exercise2(YearMonth[] ymCollection) {

            //var ym = new Exercise01.YearMonth(2005, 10);
            //if (ym .Is21Century)
            // return "21世紀";
            //else{
            // return "21世紀ではない";

            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }
 

   //5.2.3
        //メソッドを作成｛メソッド名:FindFirst21c｝
     private static YearMonth? FindFirst21c(YearMonth[] ymCollection) {
 //mita           

            foreach (var ym in ymCollection) {
                if (ym.Is21Century)
                    return ym;
                }
                return null;
     
            }
        private static void Exercise4(YearMonth[] ymCollection) {

            var first21c = FindFirst21c(ymCollection);
            if (first21c is null) {
                Console.WriteLine("21世紀のデータはありません");
            } else {
                Console.WriteLine(first21c);
            }
            //null合体演算子

          //Console.WriteLine(first21c?.ToString() ?? "21世紀のデータはありません");
        }
        private static void Exercise5(YearMonth[] ymCollection) {

            var array = ymCollection.Select()



        }
    }
}
