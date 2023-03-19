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
            List<Lesson> list = new List<Lesson>();
            Lesson lesson = new Lesson();
            lesson.name = "Math";
            lesson.id = 1;
            lesson.lessonTime = 5;
            list.Add(lesson);

            Lesson lesson1 = new Lesson();
            lesson1.name = "Social";
            lesson1.id = 2;
            lesson1.lessonTime = 4;
            list.Add(lesson1);

            Student asiye = new Student("Ela", 25, "24.02.2222", "Student", 22, "numeric part",list);
            asiye.StudentInfo();

            asiye.lessonInfo();
            Console.ReadLine();
        }
    }
}
