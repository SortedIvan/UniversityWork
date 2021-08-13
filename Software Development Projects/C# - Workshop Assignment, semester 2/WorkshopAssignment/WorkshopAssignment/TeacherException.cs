using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment
{
    //Teacher exception - it is used to check whether a teacher / student is being selected and limit access
    public class TeacherException  : Exception
    {
        public TeacherException(string message) : base($"{message}")
        {

        }
    }
}
