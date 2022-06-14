﻿using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
           　_score = ReadScore(filePath);
        }

        //生徒データを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] Lines = File.ReadAllLines(filePath);
            foreach (string Line in Lines) {
                string[] items = Line.Split(',');
                Student student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);
            }
            return students;
        }

        //科目別点数を求める 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    dict[student.Subject] += student.Score;
                else
                    dict[student.Subject] = student.Score;
            }
            return dict;




            
        }
    }
}
