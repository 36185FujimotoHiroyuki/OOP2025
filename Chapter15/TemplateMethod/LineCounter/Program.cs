using TextFileProcessor;

namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {



            Console.WriteLine("出力");

            string path = $@"{Console.ReadLine()}";
            TextProcessor.Run<LineCounterProcessor>(path); 

        }
    }
}
