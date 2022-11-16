using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Family
    {
        public Person mother;
        public Person father;
        public List<Person> children;

        public Family(Person mother, Person father)
        {
            this.mother = mother;
            this.father = father;
            children = new List<Person>();
        }

        public Family(Person mother, Person father, List<Person> children)
            : this(mother,father)
        {
            this.children = children;
        }
    }
}
