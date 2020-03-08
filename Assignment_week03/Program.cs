using System;
using System.Collections.Generic;
using System.Text;

namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
            Console.ReadLine();
            
        }
        void Start()
        {
            Course course = ReadCourse("Enter a course.");


        }

        PracticalGrade ReadPracticalGrade(string question)
        {

        }
        
        void DisplayPracticalGrade(PracticalGrade Practical)
        {

        }

        Course ReadCourse(string question)
        {
            Console.WriteLine(question);
            Console.Write("Name of the course: ");


        }

        void DisplayCourse()
        {

        }

        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
