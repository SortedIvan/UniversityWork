using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;

namespace WorkshopAssignment.Workshop
{
    //Workshop factory - used to create the workshops
    public interface IWorkshopFactory
    {
        Workshop CreateWorkshop(DateTime startDate,Person teacher, string workshopTitle, string type, int maxCapacity, string topicDescription, bool started, string url, string address, string roomNr);
    }
}
