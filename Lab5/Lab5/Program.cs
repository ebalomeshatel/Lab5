using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        delegate void Method();

        static void Edit(LastTest lasttest)
        {
            int choice = 0;
            Console.WriteLine("MENU (make your choice): (1 - Mark || 2 - Correct answers || 3 - Total score || 4 - Results)\n");
            choice = Convert.ToInt32(Console.ReadLine());
            Method edit;
            switch (choice)
            {
                case 1:
                    edit = lasttest.Edit_FirstTest;
                    edit();
                    break;
                case 2:
                    edit = lasttest.Edit_Exam;
                    edit();
                    break;
                case 3:
                    edit = lasttest.Edit_LastExam;
                    edit();
                    break;
                case 4:
                    edit = lasttest.Edit_LastTest;
                    edit();
                    break;
                default:
                    Console.WriteLine("Error input");
                    break;
            }
        }
        static void Print(LastTest lasttest)
        {
            Method pointer;
            pointer = lasttest.Output_first_test;
            pointer += lasttest.Output_Exam;
            pointer += lasttest.Output_LastExam;
            pointer += lasttest.Output_LastTest;
            pointer();
        }

        static void Main(string[] args)
        {
            int selection = 0;
            LastTest lasttest = new LastTest("Math", 25, "Kurpol Vlad", "Nikto", 1, 30, 24, "Passed");

            Print(lasttest);

        Link:
            Console.WriteLine("\nYou can change the information. Do you want to do it?(Yes - 1 | Exit - 2)");
            selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Edit(lasttest);
                    Print(lasttest);
                    goto Link;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nError input!");
                    goto Link;
            }
            Console.ReadKey();
        }
    }
}
