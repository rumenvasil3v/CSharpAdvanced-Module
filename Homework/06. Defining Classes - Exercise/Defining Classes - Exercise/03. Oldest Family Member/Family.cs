using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People
        {
            get
            {
                return this.people;
            }
            set
            {
                this.people = value;
            }
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = this.People.MaxBy(p => p.Age);

            return oldestMember;
        }
    }
}
