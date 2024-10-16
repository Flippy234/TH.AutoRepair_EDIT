using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.AutoRepair.BL
{
    public class Vehicle
    {

        private int year = DateTime.Now.Year;

        public string Make { get; set; } = "";

        public string Model { get; set; } = "";

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900) throw new InvalidYearException(value);
                year = value;
            }
        }

        public Vehicle() { }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
