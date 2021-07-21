using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul2HW6.Models;

namespace Modul2HW6.Helpers
{
    public class PowerComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var first = x as Appliance;
            var second = y as Appliance;
            if (first == null || second == null)
            {
                throw new NotImplementedException("Failed to compare");
            }

            if (first.Power > second.Power)
            {
                return 1;
            }
            else if (first.Power < second.Power)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
