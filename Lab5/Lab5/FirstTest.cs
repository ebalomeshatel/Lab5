using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class FirstTest : ISubject, IInformation
    {
        private string subject;
        private int classroom;
        private string student_name;
        private string teacher_name;
        private int mark;
        public string Subject { get => subject; set => subject = value; }
        public int Classroom { get => classroom; set => classroom = value; }
        public string Student_name { get => student_name; set => student_name = value; }
        public string Teacher_name { get => teacher_name; set => teacher_name = value; }
        public int Mark { get => mark; set => mark = value; }

        public FirstTest(string subject, int classroom, string student_name, string teacher_name, int mark)
        {
            Subject = subject;
            Classroom = classroom;
            Student_name = student_name;
            Teacher_name = teacher_name;
            Mark = mark;
        }

        public FirstTest()
        {

        }
        public void Output_first_test()
        {
            Console.WriteLine("\nSubject: " + Subject + "\nClassroom: " + Classroom + "\nStudent`s name: " + Student_name + "\nTeacher`s name: " + Teacher_name + "\nMark: " + Mark);
        }
        public void Edit_FirstTest()
        {
            Console.Clear();
            Console.WriteLine("Change the mark of a student:\n");
            Mark = Convert.ToInt32(Console.ReadLine());
        }
    }
}
