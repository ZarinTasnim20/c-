using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPerformance1
{
    class Program
    {
        static void Main(string[] args)
        {
            University uni1 = new University();
            Student[] student = new Student[5];
            student[0] = new Student();
            student[0].Cgpa = 3.95;
            student[0].Name = "lamia";
            student[0].Id = "2001";
            student[1] = new Student();
            student[1].Cgpa = 3.56;
            student[1].Name = "oishi";
            student[1].Id = "2002";
            student[2] = new Student();
            student[2].Cgpa = 3.85;
            student[2].Name = "tasnim";
            student[2].Id = "2003";
            student[3] = new Student();
            student[3].Cgpa = 3.50;
            student[3].Name = "zarin";
            student[3].Id = "2004";
            student[4] = new Student();
            student[4].Cgpa = 3.78;
            student[4].Name = "zara";
            student[4].Id = "2005";
            
            uni1.StudentProperty = student;
            Console.WriteLine("Student With Highest CGPA :\n");
            uni1.StudentWithHighestCgpa();
        }
    }
}
