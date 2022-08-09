using GPCalculator.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPCalculator.UI
{
    class DrawTable : Calculations
    {
        public static void GetTableDetails(List<CourseInformation> list)
        {
            var report = new StringBuilder();
            report.AppendLine("|----------------|--------------|--------|-------------|------------|----------|");

            report.AppendLine("| COURSE & CODE  | COURSE UNIT  | GRADE  | GRADE UNIT  | WEIGHT Pt. | REMARK   |");
            report.AppendLine("|----------------|--------------|--------|-------------|------------|----------|");

            foreach (var item in list)
            {
                report.AppendLine($"|{item.CourseCode.ToUpper()}{string.Concat(Enumerable.Repeat(" ", 16 - item.CourseCode.Length))}| " +
                    $"{item.CourseUnit}{string.Concat(Enumerable.Repeat(" ", 13 - item.CourseUnit.ToString().Length))}|" +
                    $"{item.Grade}{string.Concat(Enumerable.Repeat(" ", 8 - item.Grade.Length))}|" +
                    $"{item.GradeUnit}{string.Concat(Enumerable.Repeat(" ", 13 - item.GradeUnit.ToString().Length))}|" +
                    $"{item.WeightPoint}{string.Concat(Enumerable.Repeat(" ", 12 - item.WeightPoint.ToString().Length))}|" +
                    $"{item.Remark}{string.Concat(Enumerable.Repeat(" ", 10  - item.Remark.Length))}|");
            }
            report.AppendLine("|------------------------------------------------------|------------|----------|");
            Console.WriteLine(report);
        }
        public static void GPReport(List<CourseInformation> courseinfo)
        {
            var finalInfo = GetReportValues(courseinfo);
            Console.WriteLine($"Total Course Unit Registered is {finalInfo.CourseUnitRegistered}");
            Console.WriteLine($"Total Course Unit Passed is {finalInfo.CourseUnitPassed}");
            Console.WriteLine($"Total Weight Point is {finalInfo.TotalWeightPoint}");
            Console.WriteLine($"Your GPA is = {finalInfo.GPA.ToString("#.00")} to 2 decimal places.");

        }
    }
}
