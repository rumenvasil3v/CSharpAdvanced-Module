using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        private string university;
        private List<string> courses;
        protected int room;
        internal string averageGrade;
        public string nickName;
        public string nationality;

        public Student() : base("Pesho", 19, "bulgarian")
        {

        }

        public string University { get { return this.university; } set { this.university = value; } }

        public List<string> Vourses { get { return this.courses; } set { this.courses = value; } }

        public void PrintStudent()
        {
            Console.WriteLine($"{base.Name} - {base.Nationality} - {base.Age}");

            string nationality = string.Empty;

            Console.WriteLine(nationality);
            Console.WriteLine(this.nationality);
            Console.WriteLine(base.nationality);
        }
    }
}