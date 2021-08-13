using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment.People
{
    public class AddedPersonException : Exception
    {
        public AddedPersonException(string message) : base($"{message} has been successfully added!")
        {

        }
    }
}
