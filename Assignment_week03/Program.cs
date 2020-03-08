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
            Console.ReadKey();
            
        }
        void Start()
        {
            Course course = ReadCourse("Enter a course.");
            //DisplayPracticalGrade();
            DisplayCourse(course);
        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            string practical = ReadString(question);
            int Pgrade = int.Parse(practical);
            return(PracticalGrade)Pgrade;
        }
        
        void DisplayPracticalGrade(PracticalGrade Practical)
        {

        }

        Course ReadCourse(string question)
        {
            Course course = new Course();
            Console.WriteLine(question);
            course.name = ReadString("Name of the course: ");
            course.Grade = ReadInt($"Grade for {course.name}: ", 0, 100);
            Console.WriteLine("0. None 1. Abset 2. Insufficient 3. Sufficient 4. Good");
            course.PracticalGrade = ReadPracticalGrade($"Pratical grade for {course.name}: ");
            return course;        
        }

        void DisplayCourse(Course course)
        {
            Console.WriteLine($"{course.name} : {course.Grade}     {course.PracticalGrade}");
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }

        int ReadInt(string question, int min, int max)
        {
            int grade = 0;
            do
            {
                grade = ReadInt(question);
            }
            while (grade < min || grade > max);
            return grade;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
