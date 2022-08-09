using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPCalculator.UI;

namespace GPCalculator.CORE
{
    public class CourseInformation
    {
        public static List<CourseInformation> CourseList = new ();

        public string CourseCode { get; set; }
        public int CourseUnit { get; set; }
        public double Score { get; set; }
        public string Grade { get; set; }
        public int GradeUnit { get; set; }
        public string Remark { get; set; }
        public int WeightPoint { get; set; }

        public CourseInformation(string courseCode, int courseUnit, double score)
        {
            CourseCode = courseCode;
            CourseUnit = courseUnit;
            Score = score;
        }

        public static void AddCourse(string courseCode, int courseUnit, double score)
        {
            CourseInformation data = new (courseCode, courseUnit, score);
            DrawTable.GetGrade(data);
            CourseList.Add(data);
        }


    }
}
