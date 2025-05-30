using System.Globalization;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {


          //  var target = "C# Programming";
           // var isExists = target.All(c => Char.IsAsciiHexDigitLower(c));


            var str1 = Console.ReadLine();


            if (int.TryParse(str1, out int number)) {

                string formatted = number.ToString("N0");
               Console.WriteLine(": " + formatted);
            } else {
                Console.WriteLine();















                //  var str1 = "JSON";
                //  var str2 = "J S O N ";

                // var cultureinfo = new CultureInfo("ja-JP");
                // if (String.Compare(str1, str2, cultureinfo, CompareOptions.IgnoreKanaType) == 0) {

                //     Console.WriteLine("一致しています");
                //}






            }
    }
}
