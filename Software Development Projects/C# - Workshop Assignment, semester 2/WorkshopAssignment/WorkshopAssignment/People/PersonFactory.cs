using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment.People
{
    public class PersonFactory : IPersonFactory
    {
        
        public PersonFactory()
        {

        }

        public Person CreatePerson(string name, string email, string pcn, string course, string type)
        {
            switch (type)
            {
                case "STUDENT":
                    Person student = new Student(name,email,pcn,course);
                    return student;
                    
                case "TEACHER":
                    Person teacher = new Teacher(name,email,pcn,course);
                    return teacher;
            }
            return null;
        }
    }
}
