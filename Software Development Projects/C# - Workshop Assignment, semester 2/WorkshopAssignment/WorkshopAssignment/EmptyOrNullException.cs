using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment
{
    class EmptyOrNullException : Exception
    {
        public EmptyOrNullException(string message) : base($"{message} can't be empty!")
        {

        }

    }
}
