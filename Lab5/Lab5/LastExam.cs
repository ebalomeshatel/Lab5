using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class LastExam : Exam
    {
        private int total_score;
        public int Total_score { get => total_score; set => total_score = value; }

        public LastExam(string subject, int classroom, string student_name, string teacher_name, int mark, int correct_answers, int total_score)
            : base(subject, classroom, student_name, teacher_name, mark, correct_answers)
        {
            Total_score = total_score;
        }

        public LastExam()
        {

        }
        public void Output_LastExam()
        {
            Console.WriteLine("\nTotal score: " + Total_score);
        }
        public void Edit_LastExam()
        {
            Console.Clear();
            Console.WriteLine("Change the total score:\n");
            Total_score = Convert.ToInt32(Console.ReadLine());
        }
    }

}
