using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.AutoRepair.BL
{
    public class InvalidYearException : Exception
    {
        public InvalidYearException(int invalidYear)
            : base($"Vehicles were not invented in {invalidYear}!") { }
    }
}
