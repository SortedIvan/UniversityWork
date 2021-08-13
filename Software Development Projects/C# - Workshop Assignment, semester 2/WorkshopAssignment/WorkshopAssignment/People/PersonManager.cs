using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WorkshopAssignment.People
{
    public class PersonManager
    {
        private List<Person> people;
        private PersonFactory personFactory;

        public PersonManager()
        {
            this.people = new List<Person>();
            this.personFactory = new PersonFactory();
        }


        public Person FindPersonByPcn(string value)
        {
            foreach(var v in this.people)
            {
                if (v.GetPcn() == value)
                {
                    return v;
                }
            }
            return null;
        }
        public PersonFactory PersonFactory
        {
            get
            {
                return this.personFactory;
            }
        }

        public void CheckIfPcnExists(string pcn)
        {
            foreach(var v in this.people)
            {
                if(pcn == v.GetPcn())
                {
                    throw new AlreadyExistingException("Person");
                }
            }
        }

        public void CheckIfEmailExists(string email)
        {
            foreach(var v in this.people)
            {
                if(email == v.Email)
                {
                    throw new AlreadyExistingException("Email");
                }
            }
        }

        public void CheckIfUserExists(string name)
        {
            foreach(var v in this.people)
            {
                if(name == v.GetName())
                {
                    throw new AlreadyExistingException("Person");
                }
            }
        }

        public void AddPerson(string name, string email, string pcn, string course, string type)
        {
            this.people.Add(this.personFactory.CreatePerson(name, email, pcn, course, type));
        }

        public Person GetPerson(int index)
        {
                return this.people.ElementAt(index);
            
        }


        public List<Person> GetTeachers()
        {
            List<Person> workshopTeachers = new List<Person>();
            for(int i = 0; i < people.Count; i++)
            {
                if(this.people.ElementAt(i) is Teacher)
                {
                    workshopTeachers.Add(this.people.ElementAt(i));
                    
                }

            }
            return workshopTeachers;
        }

        //public Person GetStudent(int index)
        //{
        //    return this.GetStudents().ElementAt(index);
        //}

        public Person GetStudent(int index)
        {
            return this.GetStudents().ElementAt(index);
        }

        public List<Person> GetStudents()
        {
            List<Person> workshopStudents = new List<Person>();
            for(int i = 0; i < people.Count; i++)
            {
                if(this.people.ElementAt(i) is Student)
                {
                    workshopStudents.Add(this.people.ElementAt(i));
                }
            }
            return workshopStudents;
        }

        public Person GetTeacher1(int index)
        {
            return GetTeachers().ElementAt(index);
        }

        

        public string GetOccupation(int index)
        {
            if(people.ElementAt(index) is Teacher)
            {
                return "TEACHER";
            }
            else if(people.ElementAt(index) is Student)
            {
                return "STUDENT";
            }
            return null;
        }
        
        public void DeletePerson(int index)
        {
            this.people.RemoveAt(index);
        }

        public List<Person> GetPeople()
        {
            return this.people;
        }
    }
}
