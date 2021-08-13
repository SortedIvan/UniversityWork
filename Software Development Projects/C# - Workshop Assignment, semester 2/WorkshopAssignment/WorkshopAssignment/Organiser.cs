using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;
using WorkshopAssignment.Workshop;

namespace WorkshopAssignment
{
    //Organiser class - it is the middleman between the Workshop manager class and the Person Manager class
    public class Organiser
    {
        private WorkshopManager workshopManager;
        private PersonManager personManager;
        
        public Organiser()
        {
            this.workshopManager = new WorkshopManager();
            this.personManager = new PersonManager();
        }

        public void AddStudentToOnlineWorkshop(int indexS, int indexW)
        {

                if (this.workshopManager.GetWorkshop(indexW).GetPeopleInWorkshop().Count < this.workshopManager.GetWorkshop(indexW).GetMaxCapacity())
                {
                this.workshopManager.GetWorkshop(indexW).GetPeopleInWorkshop().Add(this.PersonManager.GetStudent(indexS));
                }
            else
            {
                throw new Exception("Workshop is full!");
            }
            double percentage = Convert.ToDouble(this.workshopManager.GetWorkshop(indexW).GetPeopleInWorkshop().Count)
                / this.workshopManager.GetWorkshop(indexW).GetMaxCapacity() * 100;

            if(percentage >= 90)
            {
                this.workshopManager.GetWorkshop(indexW).Workshop90Percent.Invoke
                    ($"Workshop {this.workshopManager.GetWorkshop(indexW).GetWorkshopTitle()} is {percentage.ToString("0.00")} % full");
            }

        }

        


        public void StartWorkshop(int index)
        {
            this.WorkshopManager.StartWorkshop(index);
        }



        public WorkshopManager WorkshopManager
        {
            get
            {
                return this.workshopManager;
            }
        }
        
        public PersonManager PersonManager
        {
            get
            {
                return this.personManager;
            }
        }
    }
}
