using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;

namespace WorkshopAssignment.Workshop
{
    //BuildingWorkshop class - it is used to create workshops on-site
    public class BuildingWorkshop : Workshop
    {
        private string address;
        private string roomNr;

        public BuildingWorkshop(DateTime startDate,string address, string roomNr, Person teacher, string workshopTitle, int maxCapacity, string topicDescription, bool started)
            :base(startDate, teacher, workshopTitle, maxCapacity, topicDescription, started)
        {
            this.address = address;
            this.roomNr = roomNr;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public string GetRoomNr()
        {
            return this.roomNr;
        }

        public override List<string> GenerateIdentifiers()
        {
            List<string> loginCodes = new List<string>();


            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            loginCodes.Add(finalString);
            return loginCodes;

        }
        public override string ToString()
        {
            return "INBUILDING" + base.ToString() + $"Location: {this.address}||{this.roomNr})";
        }
    }
}
