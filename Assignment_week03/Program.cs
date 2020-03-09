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
            //Course course = ReadCourse("Enter a course.");
            //DisplayPracticalGrade();
            //DisplayCourse(course);

            //part c
            List<Course>report;
            report = ReadReport();
            Console.WriteLine();//for spacing
            DisplayReport(report);
        }
        List<Course> ReadReport()
        {
            List<Course> r = new List<Course>();
            for(int i = 0; i <=2; i++)
            {
                Course c = new Course();
                c = ReadCourse("Enter a Course: ");
                r.Add(c); //add the course to the list of report+
                Console.WriteLine();//spacing between course input
            }
            return r;

        }

        void DisplayReport(List<Course> report)
        {
            int passed = 0;
            int CumLaude = 0;
            int retake = 0;
            for (int i =0; i<=2; i++)
            {
                DisplayCourse(report[i]);
                if (report[i].Passed())
                {
                    passed++;
                }
                else
                {
                    //to count for the retakes.
                    retake++;
                }

                if (report[i].CumLaude())
                {
                    CumLaude++;
                }
            }
            if (passed < 3)
            {
                Console.WriteLine($"Too bad!! You failed, you got {retake} retakes.");
            }
            else if (CumLaude > 0)
            {
                Console.WriteLine("Congratulation you passed with a Cum Luade reults");
            }
            else
            {
                Console.WriteLine("Congratulation!! you passed");
            }
        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            string practical = ReadString(question);
            int Pgrade = int.Parse(practical);
            return(PracticalGrade)Pgrade;
        }
        
        void DisplayPracticalGrade(PracticalGrade Practical)
        {
            Console.WriteLine(Practical);
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
