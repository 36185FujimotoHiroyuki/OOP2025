namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {

            SalesCounter sales = new SalesCounter(ReadSales(@"data\sales.csv"));
            //変更後↓       
            // new Dictionary<string, int>();
            Dictionary<string, int> amountsPerstore = sales.GetPerStoreSales();//←変更前
            amountsPerstore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string, int> obj in amountsPerstore) {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }
        }









        // ReadSales(@"data\sales.csv");


        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
       // static List<Sale> ReadSales(string filePath) {
            //売り上げデータを入れるリストオブジェクトを生成
         //   List<Sale> sales = new List<Sale>();
            //ファイルを一気に読み込む
         //   string[] lines = File.ReadAllLines(filePath);
            //読み込んだ行数分繰り返し
         //   foreach (string line in lines) {
          //      String[] items = line.Split(',');
                //Saleオブジェクトを生成
           //     Sale sale = new Sale() {

            //        ShopName = items[0],
            //        ProductCategory = items[1],
            //        Amount = int.Parse(items[2]),


              //  };
              //  sales.Add(sale);
          //  }

          //  return sales;

        }



    }

