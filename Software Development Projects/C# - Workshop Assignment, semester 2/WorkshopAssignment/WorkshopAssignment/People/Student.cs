using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment.People
{
    public class Student : Person
    {
        public Student(string name, string email, string pcn, string course) : base(name, email, pcn, course)
        {

        }
        public override string ToString()
        {
            return "STUDENT| " + base.ToString();
        }
    }
}
