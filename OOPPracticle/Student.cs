using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPracticle
{
    internal class Student:People
    {
        public int number { get; set; }
        public string branch { get; set; }
        public List<Lesson> lessons { get; set; }

        public Student(string name, int age, string birthday, string userJob,int number,string branch,List<Lesson> lessons) : base(name, age, birthday, userJob)
        {
            this.number = number;
            this.branch = branch;   
            this.lessons = lessons;
        }

        public void lessonInfo()
        {
            foreach (var lesson in lessons)
            {
                Console.WriteLine(lesson.name);
                Console.WriteLine(lesson.lessonTime);

                
            }
        }
        public void StudentInfo()
        {
            Console.WriteLine("Hi my number" + number + "and branch"+ branch);
           
        }
    }
}
