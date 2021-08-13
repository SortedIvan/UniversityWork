using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationHubApp
{
    [Serializable]
    class BlankException : Exception
    {
        
        //Catches exceptions
        public BlankException(string message)
            :base($"Please fill in the: {message}")
        {

        }



    }
}
