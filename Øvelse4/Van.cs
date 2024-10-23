using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    internal class Van : Vehicle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="licenseplate"></param>
        public Van(string owner, string licenseplate) : base(owner, licenseplate)
        {
            base.Owner = owner;
            base.Licenseplate = licenseplate;
            base.Type = "Van";
        }
    }
}