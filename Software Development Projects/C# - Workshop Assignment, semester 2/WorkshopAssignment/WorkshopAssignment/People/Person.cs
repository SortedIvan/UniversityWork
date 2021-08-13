using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopAssignment.People
{
    //Person class - used to create people - has 2 inheritants (student/teacher) *can be extended*
    public class Person
    {
        private string name;
        private string email;
        private string pcn;
        private string course;

        public Person(string name, string email, string pcn, string course)
        {
            this.name = name;
            this.email = email;
            this.pcn = pcn;
            this.course = course;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }


        public string Pcn
        {
            get
            {
                return this.pcn;
            }
            set
            {
                this.pcn = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }


        public string GetName()
        {
            return this.name;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetPcn()
        {
            return this.pcn;
        }

        public string GetCourse()
        {
            return this.course;
        }

        public override string ToString()
        {
            return $"Name:{this.name}||PCN: {this.pcn}||Course: {this.course}";
        }
    }
}
