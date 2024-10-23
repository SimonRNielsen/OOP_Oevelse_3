using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    /// <summary>
    /// Super-class/parent
    /// </summary>
    public abstract class Vehicle
    {
        #region Fields
        protected string owner;
        protected string licenseplate;
        protected string type;
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor-template for super-class
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="licenseplate"></param>
        public Vehicle(string owner, string licenseplate)
        {
            this.Owner = owner;
            this.Licenseplate = licenseplate;
        }
        #endregion
        #region Property
        /// <summary>
        /// Method to get/set licenseplate
        /// </summary>
        public string Licenseplate { get => licenseplate; set => licenseplate = value; }
        /// <summary>
        /// Method to get/set owner
        /// </summary>
        public string Owner { get => owner; set => owner = value; }
        /// <summary>
        /// Method to get/set vehicletype
        /// </summary>
        public string Type { get => type; set => type = value; }
        #endregion
    }
}