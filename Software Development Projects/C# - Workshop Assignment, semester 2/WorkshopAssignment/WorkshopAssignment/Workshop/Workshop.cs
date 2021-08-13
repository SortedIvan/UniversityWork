using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopAssignment.People;

namespace WorkshopAssignment.Workshop
{
    //Abstract workshop class - it's used to build the different types of workshops
    public abstract class Workshop
    {
            private List<Person> peopleInWorkshop;
            private string workshopTitle;
            private int maxCapacity;
            private string topicDescription;
            private bool started;
            private Person teacher;
            private DateTime startDate;
            private delegate bool capacityCheck();
            private event capacityCheck CheckCapacity;
            

        public Workshop(DateTime startDate,Person teacher,string workshopTitle, int maxCapacity, string topicDescription, bool started)
            {
                this.startDate = startDate;
                this.teacher = teacher;
                this.workshopTitle = workshopTitle;
                this.maxCapacity = maxCapacity;
                this.topicDescription = topicDescription;
                this.started = false;
                this.peopleInWorkshop = new List<Person>();
            }


            public EventHandler Workshop90Percent;
            public string GetWorkshopTitle()
            {
            return this.workshopTitle;
            }

            public int GetMaxCapacity()
            {
            return this.maxCapacity;
            }
            
            public void SetMaxCapacity(int newCapacity)
            {
            this.maxCapacity = newCapacity;
            }

            public void SetWorkshopTitle(string workshopTitle)
            {
            this.workshopTitle = workshopTitle;
            }

            public void SetWorkshopDescription(string description)
            {
            this.topicDescription = description;
            }

            public string GetTopicDescription()
            {
            return this.topicDescription;
            }

            public Person GetTeacher()
            {
            return this.teacher;
            }

            public DateTime GetStartDate()
            {
            return this.startDate;
            }
            public bool Started
            {
                get
                {
                    return this.started;
                }
                set
                {
                    this.started = value;
                }
            }

            public abstract List<string> GenerateIdentifiers();

            public List<Person> GetPeopleInWorkshop()
            {
            return this.peopleInWorkshop;
            }
            public override string ToString()
            {
                return $"(Teacher: {this.teacher}||Title: {this.workshopTitle}, Description: {this.topicDescription}, Capacity: {this.maxCapacity}";
            }

    }
}
