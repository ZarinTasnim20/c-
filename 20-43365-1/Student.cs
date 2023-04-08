using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPerformance1
{
    class Student
    {
        private string id;
        private string name;
        private double cgpa;
        public string Id
        {
            set { this.id = value; }
            get {return this.id; }
        }
        public double Cgpa
        {
            set { this.cgpa = value; }
            get{return this.cgpa; }
        }
        public string Name
        {
            set { this. name= value; }
            get { return this.name; }
        }
        public void ShowDetails()
        {
            Console.WriteLine("Student ID: " + this.id);
            Console.WriteLine("Student Name: " + this.name);
            Console.WriteLine("Student CGPA: " + this.cgpa);
        }
    }
}
