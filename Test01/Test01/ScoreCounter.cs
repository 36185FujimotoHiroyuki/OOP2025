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

            var student = new List<Student>();

            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines) {
                String[] items = line.Split(',');

                Student sale = new Student() {

                    Name = items[0],
                    Subject = items[1],
                    Score = int.Student(items[2]),


                };
                Student.Add(student);
            }
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {


            var score = new SortedDictionary<string, int>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

        }
    }




    }
    

