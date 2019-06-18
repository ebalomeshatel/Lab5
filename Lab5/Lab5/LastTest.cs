using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class LastTest : LastExam
    {
        private string result;
        public string Result { get => result; set => result = value; }

        public LastTest(string subject, int classroom, string student_name, string teacher_name, int mark, int correct_answers, int total_score, string result)
            : base(subject, classroom, student_name, teacher_name, mark, correct_answers, total_score)
        {
            Result = result;
        }

        public LastTest()
        {

        }
        public void Output_LastTest()
        {
            Console.WriteLine("\nResult of exams: " + Result);
        }
        public void Edit_LastTest()
        {
            Console.Clear();
            Console.WriteLine("New result of exam:\n");
            Result = Console.ReadLine();
        }
    }
}
