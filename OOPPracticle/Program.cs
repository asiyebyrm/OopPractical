using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student asiye = new Student("Ela", 25, "24.02.2222", "Student", 22, "numeric part");
            asiye.StudentInfo();
        }
    }
}
