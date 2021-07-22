using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models.Appliances.ComputingDevices;

namespace Appliances.Models.Appliances.ComputingDevices.Portables
{
    public abstract class Smartphone : Portable
    {
        public int SimCardQuantity { get; set; }
    }
}
