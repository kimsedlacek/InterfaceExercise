using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany    
    {
        public string DriveTrain { get; set; }
        public string Color { get; set; }
        public string Year { get ; set ; }
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public int WarningIndicators { get ; set ; }
        public int YearsOpen { get ; set ; }
        public string Motto { get ; set ; }
    }
}
