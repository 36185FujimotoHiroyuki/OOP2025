
using System.Globalization;
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
        }

        private static void Exercise6(string text) {
            var letter = text.ToLower().Replace(" ", " ");
            // var letter = text.ToLower();
            //  .Where(char.IsLetter)
            // .GroupBy(c => c)
            // .Select(group => new { Letter = group.Key, Count = group.Count() })
            // .OrderBy(result => result.Letter)
            // .ToList();

            // Console.WriteLine("出現アルファベットの個数:");
            // foreach (var item in letter) {
            {

                //   Console.WriteLine($"{item.Letter}:{item.Count}");
//辞書で集計
                var alphDicCount = Enumerable.Range('a', 26)
                    .ToDictionary(num => ((char)num).ToString(), num => 0);

                foreach (var alph in letter) {
                    alphDicCount[alph.ToString()]++;
                }
                foreach (var item in alphDicCount) {
                    Console.WriteLine($"{item.Key}:{item.Value}");


                    //配列の集計

                    var array = Enumerable.Repeat(0, 26).ToArray();
                    foreach(var alph in letter) {
                        array[alph - 'a']++;
                    }
                    for (char ch = 'a'; ch <= 'a'; ch++) {
                        Console.WriteLine($"{ch}:{array[ch - 'a']}");
                    }
                    Console.WriteLine();

            //'a'から順にカウントして出力

                    for (char ch ='a'; ch <= 'z'; ch++) {
                        Console.WriteLine($"{ch}:{text.Count(tc => tc == ch)}");
                }






                }
            }
        }
        private static void Exercise1(string text) {
            var spaces = text.Count(c => c == ' ');
                                 //(char.IsWhiteSpace);別回答
            Console.WriteLine("空白数：", spaces);
        }
        #region
        //教科書   //  if (string.IsNullOrEmpty(text)) {
        //    Console.WriteLine();
        //     return;
        //  }
        // int spaceCount = 0;
        //        foreach (var ch in text) {
        //            if (char.IsWhiteSpace(ch)) {
        //                 spaceCount++;
        //   }
        // }

        #endregion
        // updatedText
        private static void Exercise2(string text) {
            var replaceText = text.Replace("big", "small");
            Console.WriteLine(replaceText);

        }

        private static void Exercise3(string text) {

            var array = text.Split(' ');
            var sb = new StringBuilder(array[0]);
            foreach (var word in array.Skip(1)) {

               sb.Append(word + " "); 
          }    
              string result = sb.ToString().TrimEnd();
               Console.WriteLine(result);

            }
        private static void Exercise4(string text) {
            //正解コード
            var count = text.Split(' ').Length;

            Console.WriteLine("単語の数:",count);
        }
        private static void Exercise5(string text) {

            var words = text.Split(' ').Where(s => s.Length <= 4);

            

        }
    }
}
