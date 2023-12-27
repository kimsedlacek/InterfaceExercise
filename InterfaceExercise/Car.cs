using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasSunroof { get; set; }
        public int Mileage { get; set; }
        public string Year { get; set; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }        
        public int WarningIndicators { get ; set ; }
        public int YearsOpen { get ; set ; }
        public string Motto { get ; set ; }
    }
}
