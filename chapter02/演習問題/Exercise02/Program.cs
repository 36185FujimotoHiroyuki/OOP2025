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
        // for (int feet = start; feet <= end; feet++) {
        //  double meter = InchConverter.ToMeter(feet);
        // Console.WriteLine($"{feet}inch = {meter:0.0000}m");
        // }

        // キーボードから入力(機能追加①)


        // Console.WriteLine("変更アプリ");
        // Console.WriteLine("１：インチからメートル");
        //  Console.WriteLine("２：メートルからインチ");
         //Console.Write("＞");

        // int choice = int.Parse(Console.ReadLine());

        // インチからメートルの変換
        // if (choice == 1)
        // {
         //   Console.WriteLine("はじめ：");
            int start = int.Parse(Console.ReadLine());
          //Console.WriteLine("おわり：");
             int end = int.Parse(Console.ReadLine());

         static void PrintInchToMeterList(int start, int end) {
            Console.WriteLine();
            PrintInchToMeterList(start, end);
       // }
        //else if (choice == 2)
       // {

            // インチからメートルへの変換
            for (int inch = start; inch <= end; inch++) {
                double meter = inch * 0.0254;  
                Console.WriteLine($"{inch} inch = {meter:0.0000} m");
            }
        }
    }












}





