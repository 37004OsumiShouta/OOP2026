using System.ComponentModel.Design;

namespace Test01_01
{
    public class ScoreCounter
    {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath)
        {
            _score = ReadScore(filePath);
        }

        //メソッドの概要：
        private static IEnumerable<Student> ReadScore(string filePath)
        {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                Student student = new Student
                {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };

                scores.Add(student);
            }
            return scores;
        }

        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore()
        {
            var dict = new Dictionary<string, int>();
            foreach (var student in _score)
            {
                if (dict.ContainsKey(student.Subject))
                {
                    dict[student.Subject] += student.Score;
                }
                else
                {
                    dict[student.Subject] = student.Score;
                }






               
            }
           return dict;
        }

    }
  
}
