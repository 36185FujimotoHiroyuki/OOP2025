
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
                if ('A' >= c && c <= 'Z') {
                    if (moji.ContainsKey(c))
                        moji[c]++;

                } else {
                    moji[c] = 1;
                }

                foreach (var item in moji.OrderBy(x => x.Value Key)) {
                    Console.WriteLine("'{0}:{1}", item.Key, item.Value);
                }


                //   foreach (var entry in moji) {
                // string hexCode = Convert.ToInt32(entry.Key).ToString("X2");
                // Console.WriteLine($"'{entry.Key}'（{hexCode}）：{entry.Value}");

            }
        }
        private static void Exercise2(string text) {
            var moji = new Dictionary<Char, int>();

            foreach (var c in text.ToUpper()) {
                if ('A' >= c && c <= 'Z') {
                    if (moji.ContainsKey(c))
                        moji[c]++;

                } else {
                    moji[c] = 1;
                }

                foreach (var item in moji) {
                    Console.WriteLine("'{0}:{1}", item.Key, item.Value);
                }
            }
        }

