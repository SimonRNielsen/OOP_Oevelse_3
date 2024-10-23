using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    public abstract class Vehicle
    {
        protected string owner;
        protected string licenseplate;
        protected string type;

        public Vehicle(string owner, string licenseplate)
        {
            this.Owner = owner;
            this.Licenseplate = licenseplate;
        }

        public string Licenseplate { get => licenseplate; set => licenseplate = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Type { get => type; set => type = value; }
    }
}
