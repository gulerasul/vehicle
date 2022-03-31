using System;
using System.Collections.Generic;
using System.Text;

namespace vehicle.Models
{
    abstract class Vehicle
    {

        public abstract int DriveTime { get; set; }
        public abstract int DrivePath { get; set; }
        public void AverageSpeed () { }
        public void ShowInfo() { }



    }
}
