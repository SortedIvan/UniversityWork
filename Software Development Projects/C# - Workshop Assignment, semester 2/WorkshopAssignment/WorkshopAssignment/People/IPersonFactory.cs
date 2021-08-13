using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment.People
{
    public interface IPersonFactory
    {
        Person CreatePerson(string name, string email, string pcn, string course, string type);
    }
}
