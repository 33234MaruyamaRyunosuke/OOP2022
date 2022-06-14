using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
           // _score = ReadScore(filePath);
           

        }


        //メソッドの概要： 
        /*private static IEnumerable<Student> ReadScore(string filePath) {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Name))
                    dict[student.Name] += student.Score;
                else
                    dict[student.Name] = student.Score;
            }
            return dict;
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {





            
        }*/
    }
}
