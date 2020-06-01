using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3
{
    class Teacher : Person
    {
        
        private string Subject { get; set; }

        public Teacher(string firstName, string middleName, string lastName, string subject, short birthDay, string gender)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Subject = subject;
            BirthDay = birthDay;
            Gender = gender;
        }
        public Teacher()
        {

        }

        public string ShortName
        {
            get
            {
                return $"{FirstName} {MiddleName.Substring(0, 1)}.{LastName.Substring(0, 1)}.";
            }
        }

        public string SubjectOfKnowledge
        {
            get
            {
                return $"Предмет обучения : {Subject}.";
            }
        }

        public int GetMark(int mark)
        {
            return mark;
        }

        

        public int markForLesson = 5;
    }
}
