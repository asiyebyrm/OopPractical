using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticle
{
    internal class Teacher:People
    {

        public int salary { get; set; }

        List<Lesson> lessons = new List<Lesson>();

        public Teacher(string name, int age, string birthday, string userJob,int salary, List<Lesson>lessons) : base(name, age, birthday, userJob)
        {
            this.salary = salary;
            this.lessons = lessons;
        }
    }

}
