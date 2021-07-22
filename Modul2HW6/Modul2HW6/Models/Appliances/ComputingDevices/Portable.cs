using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.Models.Appliances.ComputingDevices
{
   public abstract class Portable : ComputingDevice
    {
        public double BateryCapacity { get; set; }
    }
}
