using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticle
{
    internal class Student:People
    {
        private int number;
        private string branch;

        public Student(string name, int age, string birthday, string userJob,int number,string branch) : base(name, age, birthday, userJob)
        {
            this.number = number;
            this.branch = branch;   
        }
        public void StudentInfo()
        {
            Console.WriteLine("Hi my number"+number+ "and branch"+branch);
            Console.ReadLine();
        }
    }
}
