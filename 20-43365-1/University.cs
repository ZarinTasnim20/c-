using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPerformance1
{
    class University:Student
    {
      private  Student[] students = new Student[5];
       public void StudentWithHighestCgpa ()
        {
           double highest = students[0].Cgpa;
            Student s1 = null; 
           foreach(Student s in students)
           {
                if(s.Cgpa>=highest)
                {
                    s1 = s; 
                }  
           }
            s1.ShowDetails();
        }
        public Student[] StudentProperty
        {
            set { this.students = value; }
            get { return students; }
        }
    }
}
