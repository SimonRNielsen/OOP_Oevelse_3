using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse3
{
    internal class Person
    {
        private string name;
        private int age;

        public Person (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age { get => age; private set => age = value; }
        public string Name { get => name; private set => name = value; }
    }
}
