using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    public class Hatchback : Vehicle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="licenseplate"></param>
        public Hatchback (string owner, string licenseplate) : base(owner, licenseplate)
        {
            base.Owner = owner;
            base.Licenseplate = licenseplate;
            base.Type = "Hatchback";
        }
    }
}