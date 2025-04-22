﻿using System.Diagnostics.Metrics;
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

            FeetConverter Converter = new FeetConverter();
            for (int feet = start; feet <= end; feet++) {
                //double meter = feet * 0.3048;
                double meter = Converter.ToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        public void PrintmeterToMeterList(int start, int end) {
            FeetConverter Converter = new FeetConverter();
            for (int meter = start; meter <= end; meter++) {

                double feet = Converter.FromMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }


        }
    }
}

