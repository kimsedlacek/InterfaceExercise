﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int WarningIndicators { get; set; }
    }
}
