using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticle
{
    internal class People
    {
        private string name;
        private int age;
        private string birthday;
        private string userJob;

        public People(string name, int age, string birthday, string userJob)
        {
            this.name = name;
            this.age = age;
            this.birthday = birthday;
            this.userJob = userJob;
        }
    }
}
