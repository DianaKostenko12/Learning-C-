using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        public string name;
        public int age;
        public bool alive;

        public Person(string name, int age, bool alive)
        {
            this.name = name;
            this.age = age;
            this.alive = alive;
        }
    }
}
