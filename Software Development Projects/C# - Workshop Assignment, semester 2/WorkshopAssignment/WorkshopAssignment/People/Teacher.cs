using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment.People
{
    public class Teacher : Person
    {
        
        public Teacher(string name, string pcn, string email, string course):base(name, pcn, email, course)
        {

        }
        public override string ToString()
        {
            return "TEACHER| " + base.ToString();
        }
    }
}
