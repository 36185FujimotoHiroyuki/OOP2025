using System;
using System.Text.RegularExpressions;

namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllBytes("sample.txit");
            //11.4
            var newlines = lines.Select(s => Regex.Replace( s, @"\bversion\s=*\s*""v4.0""", @"version= ""v5.0"""))
            File.WriteAllLines("sampleChange.txt", newlines);

            var text = File.ReadAllText("sampleChange,txt");
            Console.WriteLine(text);



        }
    }
}
