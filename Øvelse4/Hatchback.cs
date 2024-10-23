using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    /// <summary>
    /// Sub-class vehicle-type
    /// </summary>
    public class Hatchback : Vehicle
    {
        /// <summary>
        /// Constructor for a Hatchback subclass of Vehicle
        /// </summary>
        /// <param name="owner">Name of cars owner</param>
        /// <param name="licenseplate">Licenseplate of the car</param>
        public Hatchback (string owner, string licenseplate) : base(owner, licenseplate)
        {
            base.Owner = owner;
            base.Licenseplate = licenseplate;
            base.Type = "Hatchback";
        }
    }
}