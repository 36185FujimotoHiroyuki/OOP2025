using System.Diagnostics;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace Test01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            //   public IEnumerable<Sale> ReadSales(string filePath) {

        List<Student> score = new List<Student>();
        
        string[] lines = File.ReadAllLines(filePath);
           
            foreach (string line in lines) {
                String[] items = line.Split(',');
       
        Student student = new Student() {
            Name = items[0],
            Subject = items[1],
            Score = int.Parse(items[2]),
        };
        score.Add(student);
            }
            return score;

            //(score.Subject)
            //Subject
        }
        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // var dict = new SortedDictionary<string, int>();


            // Console.WriteLine(.Sum());


            foreach (var score in _score) {
                if (dict.ContainsKey(score.Name)) {
                    dict[score.Name] += score.Score;
                } else {
                    dict[score.Name] = score.Score;
                }
            }
            return dict;
 
        }
    }




    }
    

