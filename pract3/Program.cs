using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите ФИО учителя :");
            //var firstTeacherName = Console.ReadLine();
            //var middleTeacherName = Console.ReadLine();
            //var lastTeacherName = Console.ReadLine();
            //Console.WriteLine("Введите предмет :");
            //var subject = Console.ReadLine();
            Teacher t1 = new Teacher("Сидорова", "Татьяна", "Сергеевна", "Информатика", 1980, "жен");
            Pupil p1 = new Pupil("Иванов", "Иван", "5A", 2005, "муж");
            Pupil p2 = new Pupil("Петрова", "Анна", "5B", 2006, "жен");        
 
            Console.WriteLine($"\n{t1.ShortName}");
            Console.WriteLine(t1.SubjectOfKnowledge);
            Console.WriteLine($"\n{p1.ShortName}");
            Console.WriteLine(p1.CountOfMarks);
            Console.WriteLine($"\n{p2.ShortName}");
            Console.WriteLine(p2.CountOfMarks);


            Console.ReadKey();
        }
    }
}
