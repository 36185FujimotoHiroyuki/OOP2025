﻿using System.Diagnostics;
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


        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {


            var score = new SortedDictionary<string, int>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

        }
    }




    }
    

