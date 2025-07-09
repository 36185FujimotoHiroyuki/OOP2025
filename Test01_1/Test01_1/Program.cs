namespace Test01_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var score = new ScoreCounter("StudentScore.csv");
            var TotalBySubject = score.GetPerstoreScore();
            int totalScore = 0;
            foreach (var obj in TotalBySubject)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}

//実行結果
//英語 520
//数学 550
//国語 500