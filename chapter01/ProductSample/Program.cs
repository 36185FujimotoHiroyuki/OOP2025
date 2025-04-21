namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(123, "だいふく", 280);

            //税抜きの価格を表示「かりんとうの税抜き価格は〇〇円です」
            Console.WriteLine(karinto.Name + "の税抜き価格は" + karinto.Price + "円です");
            //消費税額を表示「かりんとうの消費税額は〇〇円です」
            Console.WriteLine(karinto.Name + "消費税額" + karinto.GetTax() + "円です");
            //税込価格の表示「かりんとうの税込価格は〇〇円です」
            Console.WriteLine(karinto.Name + "税込価格" + karinto.GetTax() + "円です");
            //税込価格の表示
            Console.WriteLine(karinto.Name + "の税抜き価格" + karinto.GetPriceIncludingTax() + "円です");





            //税抜きの価格を表示「かりんとうの税抜き価格は〇〇円です」
            Console.WriteLine(daifuku.Name + "の税抜き価格は" + daifuku.Price + "円です");
            //消費税額を表示「かりんとうの消費税額は〇〇円です」
            Console.WriteLine(daifuku.Name + "消費税額" + daifuku.GetTax() + "円です");
            //税込価格の表示「かりんとうの税込価格は〇〇円です」
            Console.WriteLine(daifuku.Name + "税込価格" + daifuku.GetTax() + "円です");
            //税込価格の表示
            Console.WriteLine(daifuku.Name + "の税抜き価格" + daifuku.GetPriceIncludingTax() + "円です");








        }
    }
}
