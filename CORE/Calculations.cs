using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.CORE
{
    public class FinalInfo
    {
        public int CourseUnitRegistered { get; set; }
        public int CourseUnitPassed { get; set; }
        public int TotalWeightPoint { get; set; }
        public decimal GPA { get; set; }
    }

    public class Calculations
    {
        public static FinalInfo GetReportValues(List<CourseInformation> courseinfo)
        {
            int courseUnitRegistered = 0;
            int courseUnitPassed = 0;
            int totalWeightPoint = 0;
            foreach (var course in courseinfo)
            {
                courseUnitRegistered += course.CourseUnit;
                totalWeightPoint += course.WeightPoint;
                if (course.Score > 39)
                {
                    courseUnitPassed += course.CourseUnit;
                }

            }
            decimal GPA = totalWeightPoint / courseUnitRegistered;


            var finalInfo = new FinalInfo
            {
                CourseUnitRegistered = courseUnitRegistered,
                CourseUnitPassed = courseUnitPassed,
                TotalWeightPoint = totalWeightPoint,
                GPA = Math.Round(GPA, 2)
            };

            return finalInfo;

        }

        public static void GetGrade(CourseInformation data)
        {
            if (data.Score >= 70 && data.Score <= 100)
            {
                data.Grade = "A";
                data.GradeUnit = 5;
                data.Remark = "Excellent";
                data.WeightPoint = data.CourseUnit * 5;
            }
            else if (data.Score >= 60 && data.Score <= 69)
            {
                data.Grade = "B";
                data.GradeUnit = 4;
                data.Remark = "Very Good";
                data.WeightPoint = data.CourseUnit * 4;
            }
            else if (data.Score >= 50 && data.Score <= 59)
            {
                data.Grade = "C";
                data.GradeUnit = 3;
                data.Remark = "Good";
                data.WeightPoint = data.CourseUnit * 3;
            }
            else if (data.Score >= 45 && data.Score <= 49)
            {
                data.Grade = "D";
                data.GradeUnit = 2;
                data.Remark = "Fair";
                data.WeightPoint = data.CourseUnit * 2;
            }
            else if (data.Score >= 40 && data.Score <= 44)
            {
                data.Grade = "E";
                data.GradeUnit = 1;
                data.Remark = "Pass";
                data.WeightPoint = data.CourseUnit * 1;
            }
            else
            {
                data.Grade = "F";
                data.GradeUnit = 0;
                data.Remark = "Fail";
                data.WeightPoint = data.CourseUnit * 0;
            }
        }

    }




}
