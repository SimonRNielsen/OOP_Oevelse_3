using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_3
{
    internal class Enemy
    {
        private string name;

        public Enemy (string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
