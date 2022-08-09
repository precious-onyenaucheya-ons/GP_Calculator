using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPCalculator.CORE;


namespace GPCalculator.UI
{
    public class GetCourseDetails
    {
        public static void CourseDetails()
        {
            int courseCount;
            try
            { 
                Console.WriteLine("How Many Courses Do You Offer? ");
                courseCount = Convert.ToInt32(Console.ReadLine());

                while (courseCount > 0)
                {
                    Console.WriteLine("Input your Course Code? ");
                    string courseCode = Console.ReadLine();


                    Console.WriteLine("Input your Course Unit? ");
                    int courseUnit = Convert.ToInt32(Console.ReadLine());
                    while (courseUnit < 0 || courseUnit > 5)
                    {
                        Console.WriteLine("Out of Range! Course Unit? ");
                        courseUnit = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Input your Score? ");
                    int score = Convert.ToInt32(Console.ReadLine());
                    while (score < 0 || score > 100)
                    {
                        Console.WriteLine("Out of Range! Score? ");
                        score = Convert.ToInt32(Console.ReadLine());
                    }

                    CourseInformation.AddCourse(courseCode, courseUnit, score);
                    courseCount--;
                }
                DrawTable.GetTableDetails(CourseInformation.CourseList);
                DrawTable.GPReport(CourseInformation.CourseList);
                Console.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format!");
                CourseDetails();
                    
            }
           
        }

    }
}
