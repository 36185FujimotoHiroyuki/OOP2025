
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {


            var text = "Cozy lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();

            Exercise2(text);

        }

        private static void Exercise1(string text) {
            //1,ディクショナリ作成
            var moji = new Dictionary<Char, int>();
            //2.文字を取り出す           //3.大文字に変換

           // foreach (var c in text) {
           //   char upperCh = char.ToUpper(c);
           //  if (char.IsLetter(upperCh)) {
            foreach (var c in text.ToUpper()) {
                if (c >= 'A' && c <= 'Z') {
                for ( c)

              } else {
                    Console.WriteLine();
                }

            foreach (var entry in moji) {
                 string hexCode = Convert.ToInt32(entry.Key).ToString("X2");
                  Console.WriteLine($"'{entry.Key}'（{hexCode}）：{entry.Value}");

                    }
                }
            }

        private static void Exercise2(string text) {
       
        }
    }
}
