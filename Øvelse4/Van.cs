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
    internal class Van : Vehicle
    {
        /// <summary>
        /// Constructor for a Pickup subclass of Vehicle
        /// </summary>
        /// <param name="owner">Name of cars owner</param>
        /// <param name="licenseplate">Licenseplate of the car</param>
        public Van(string owner, string licenseplate) : base(owner, licenseplate)
        {
            base.Owner = owner;
            base.Licenseplate = licenseplate;
            base.Type = "Van";
        }
    }
}