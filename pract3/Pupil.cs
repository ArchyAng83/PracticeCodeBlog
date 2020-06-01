using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3
{
    class Pupil : Person
    {
        public string NumberOfClass { get; set; }
        public int Mark { get; set; }
        Teacher t1 = new Teacher();


        public Pupil(string firstName, string lastName, string numberOfClass, short birthDay, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            NumberOfClass = numberOfClass;
            BirthDay = birthDay;
            Gender = gender;
        }

        public string ShortName
        {
            get
            {
                return $"{FirstName} {LastName.Substring(0, 1)}.";
            }
        }

        public string CountOfMarks
        {
            get
            {
                return $"Оценка : {t1.markForLesson} по предмету ";
            }
        }
    }
}
