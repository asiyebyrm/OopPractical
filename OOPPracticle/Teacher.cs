using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticle
{
    internal class Teacher:People
    {

        private int salary;
        List<string> lessons = new List<string>();

        public Teacher(string name, int age, string birthday, string userJob,int salary, List<string>lessons) : base(name, age, birthday, userJob)
        {
            this.salary = salary;
            this.lessons = lessons;
        }
    }

}
