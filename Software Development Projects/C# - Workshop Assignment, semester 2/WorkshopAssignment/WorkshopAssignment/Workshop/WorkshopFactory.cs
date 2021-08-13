using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;

namespace WorkshopAssignment.Workshop
{
    //Workshop factory class - it is used to create all of the workshops easily
    public class WorkshopFactory : IWorkshopFactory
    {
        public WorkshopFactory()
        {

        }

        public Workshop CreateWorkshop(DateTime startDate,Person teacher, string workshopTitle, string type, int maxCapacity, string topicDescription, bool started, string url, string address, string roomNr)
        {
            if(teacher is Student)
            {
                throw new Exception("Can't add students as a teacher");
            }
            switch (type)
            {
                case "ONLINE":
                    Workshop workshop = new OnlineWorkshop(startDate,teacher, workshopTitle, maxCapacity, topicDescription, started, url);
                    return workshop;
                case "BUILDING":
                    Workshop workshop2 = new BuildingWorkshop(startDate,address, roomNr,teacher,workshopTitle,maxCapacity,topicDescription,started);
                    return workshop2;
                
            }
            return null;
        }
    }
}
