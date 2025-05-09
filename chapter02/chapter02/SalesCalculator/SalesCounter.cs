using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {//売り上げ集計クラス
    public class SalesCounter {
        private readonly List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
             _sales = ReadSales(filePath);

        }
        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
           // Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
        
                return dict;
            }


                //売り上げデータを読み込み、Saleオブジェクトのリストを返す
                public List<Sale> ReadSales(string filePath) {
            //売り上げデータを入れるリストオブジェクトを生成
            List<Sale> sales = new List<Sale>();
            //ファイルを一気に読み込む
            string[] lines = File.ReadAllLines(filePath);
            //読み込んだ行数分繰り返し
            foreach (string line in lines) {
                String[] items = line.Split(',');
                //Saleオブジェクトを生成
                Sale sale = new Sale() {

                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),


                };
                sales.Add(sale);

            }
        }
    }
}
        
















        //カテゴリー別売り上げ集計表
      //  public Dictionary<string, int> GetPerStoreSales() {
            //  dict = new Dictionary<string, int>();
        //    Dictionary<string, int> dict = new Dictionary<string, int>();
        //    foreach (Sale sale in _sales) {
         //       if (dict.ContainsKey(sale.ProductCategory))
          //          dict[sale.ProductCategory] += sale.Amount;
         //       else         //プロダクトカテゴリー
         //           dict[sale.ProductCategory] = sale.Amount;

          // }

        
    
   

