﻿
using System.Globalization;

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
