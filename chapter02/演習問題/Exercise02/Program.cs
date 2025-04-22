namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {

            int start = int.Parse(args[1]);
            int end = int.Parse(args[2]);

            double inchToMeter = 0.0254;

        
            for (int inch = 1; inch <= 10; inch++) {
                double meters = inch * inchToMeter;
                Console.WriteLine($"{inch} インチ = {meters:F4} メートル");
            }
        }

        //訂正した

        //int start = int.Parse(args[1]);
       // int end = int.Parse(args[2]);


         //   if (args.Length >= 1 && args[0] == "-tom") {
         //       PrintfeetToMeterList(start, end);
    //} else {
        //        PrintMeterToInchList(start, end);
//}

      //  }//インチからメートルへの対応表を出力
      //  static void PrintInchToMeterList(int start, int end) {

   // FeetConverter Converter = new InchConverter();
   // for (int inch = start; inch <= end; inch++) {
        //double meter = inch * 0.3048;
      //  double meter = Converter.ToMeter(inch);
       // Console.WriteLine($"{inch}ih = {meter:0.0000}m");
   // }
//}//メートルからインチへの対応表を出力

//public void PrintMeterToInchList(int start, int end) {
 //   InchConverter Converter = new InchConverter();
 //   for (int meter = start; meter <= end; meter++) {

   //     double feet = Converter.FromMeter(meter);
   //     Console.WriteLine($"{meter}m = {feet:0.0000}ih");
   // }




}

}



