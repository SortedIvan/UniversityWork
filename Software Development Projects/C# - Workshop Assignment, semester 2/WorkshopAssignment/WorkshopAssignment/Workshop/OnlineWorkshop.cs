using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;

namespace WorkshopAssignment.Workshop
{
    //OnlineWorkshop class - it is used to create workshops objects that are online
    public class OnlineWorkshop : Workshop
    {
        private string url;

        public OnlineWorkshop(DateTime startDate,Person teacher, string workshopTitle, int maxCapacity, string topicDescription, bool started, string url)
            : base(startDate,teacher, workshopTitle, maxCapacity, topicDescription, started)
        {
            this.url = url;
        }

        public string GetUrl()
        {
            return this.url;
        }
        public string Url
        {
            get
            {
                return this.url;
            }
        }



        public override List<string> GenerateIdentifiers()
        {
            int capacityCount = GetMaxCapacity();
            List<string> loginCodes = new List<string>();
            if (Started == true)
            {
                for (int z = 0; z < capacityCount; z++)
                {
                    var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    var stringChars = new char[8];
                    var random = new Random();


                    for (int i = 0; i < stringChars.Length; i++)
                    {
                        stringChars[i] = chars[random.Next(chars.Length)];
                    }

                    var finalString = new String(stringChars);
                    loginCodes.Add(finalString);

                    Array.Clear(stringChars, 0, stringChars.Length);

                }
                return loginCodes;
            }
            else
            {
                return null;
            }


        }

        public override string ToString()
        {
            return "ONLINE" + base.ToString() + $"Url: {this.url})";
        }
    }
}

