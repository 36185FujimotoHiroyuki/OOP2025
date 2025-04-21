using System.Diagnostics.Metrics;
using System.Xml.Serialization;
//コマンドライン引数で指定された範囲のフィートとメートルの対応表を出力
namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {

            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);


            if (args.Length >= 1 && args[0] == "-tom") {
                PrintfeetToMeterList(start, end);
            } else {
                PrintMeterToFeetList(start, end);
            }

        }
        static void PrintfeetToMeterList(int start, int end) {
            for (int feet = start; feet <= end; feet++) {
                //double meter = feet * 0.3048;
                double meter = FeetToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        public void PrintmeterToMeterList(int start, int end) {

            for (int meter = start; meter <= end; meter++) {

                double feet = feetToMoter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }






            static double feetToMoter(int feet) {
                return feet * 0.3048;
            }

            static double MoterTofeet(int meter) {
                return meter / 0.3048;

            }

        }
    }
}

