using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Exam : FirstTest
    {
        private int correct_answers;
        public int Correct_answers { get => correct_answers; set => correct_answers = value; }

        public Exam(string subject, int classroom, string student_name, string teacher_name, int mark, int correct_answers)
            : base(subject, classroom, student_name, teacher_name, mark)
        {
            Correct_answers = correct_answers;
        }

        public Exam()
        {

        }
        public void Output_Exam()
        {
            Console.WriteLine("\nCorrect answers: " + Correct_answers);
        }
        public void Edit_Exam()
        {
            Console.Clear();
            Console.WriteLine("Change the number of correct answers:\n");
            Correct_answers = Convert.ToInt32(Console.ReadLine());
        }
    }
}
