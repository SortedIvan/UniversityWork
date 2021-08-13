using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;
using System.IO;

namespace WorkshopAssignment.Workshop
{
    //Workshop manager class - it's used to manage all of the workshops and add them to their appropriate data structures ( lists )
    public class WorkshopManager : IFilePrinter
    {
        private WorkshopFactory workshopFactory;
        private List<Workshop> workshops = new List<Workshop>();
        private List<Workshop> startedWorkshops = new List<Workshop>();
        public LoadWorkshops allWorkshopsLoaded;

        public WorkshopManager()
        {
            this.workshopFactory = new WorkshopFactory();
        }

        public WorkshopFactory WorkshopFactory
        {
            get
            {
                return this.workshopFactory;
            }
        }

        public void AddWorkshopToList(Workshop w)
        {
            workshops.Add(w);
            

        }

        public void StartWorkshop(int index)
        {
            this.GetWorkshop(index).Started = true;
            this.startedWorkshops.Add(this.GetWorkshop(index));
            this.workshops.RemoveAt(index);
        }

        public void DeleteWorkshop(int index)
        {
            this.workshops.RemoveAt(index);
        }

        public bool AddWorkshop(DateTime startDate,Person teacher, string workshopTitle, string type, int maxCapacity, string topicDescription, bool started, string url, string address, string roomNr)
        {
            this.workshops.Add(this.workshopFactory.CreateWorkshop(startDate,teacher, workshopTitle, type, maxCapacity, topicDescription, started, url, address, roomNr));
            return true;
        }

        public Workshop GetWorkshop(int index)
        {

            return this.workshops.ElementAt(index);
                

        }

        public List<string> GetRandomCodes(int index)
        {
            List<string> codes = new List<string>();
            foreach(var v in this.GetStartedWorkshop(index).GenerateIdentifiers())
            {
                codes.Add(v);
            }
            return codes;
        }
        
        
        public string GetRandomCode(int index)
        {
            return this.GetRandomCodes(index).ElementAt(index);
        }


        public Workshop GetOnlineWorkshop(int index)
        {
            if(this.workshops.ElementAt(index) is OnlineWorkshop)
            {
                return this.workshops.ElementAt(index);
            }
            return null;
        }

        

        public Workshop GetBuildingWorkshop(int index)
        {
            if(this.workshops.ElementAt(index) is BuildingWorkshop)
            {
                return this.workshops.ElementAt(index);
            }
            return null;
        }
        public List<Workshop> GetWorkshops()
        {
            return this.workshops;
        }
        public List<Workshop> GetStartedWorkshops()
        {
            return this.startedWorkshops;
        }
        public Workshop GetStartedWorkshop(int index)
        {
            return this.startedWorkshops.ElementAt(index);
        }
        public void SaveToFile()
        {
            FileStream fs = null;
            StreamWriter sr = null;
            try
            {
                fs = new FileStream("Workshops.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sr = new StreamWriter(fs);

                foreach (var v in workshops)
                {
                    sr.WriteLine(v.ToString());
                }
                
            }
            catch (IOException)
            {

            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
