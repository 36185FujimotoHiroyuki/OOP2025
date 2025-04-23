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

        //訂正した(インチからメートルに変更）

        //       PrintfeetToMeterList(1, 10);
        //  }//インチからメートルへの対応表を出力
        //  static void PrintInchToMeterList(int start, int end) {
        // for (int inch = start; inch <= end; inch++) {
        //  double meter = InchConverter.ToMeter(inch);
        // Console.WriteLine($"{inch}ih = {meter:0.0000}m");
        // }
        

       

    }
}




















    }

}



