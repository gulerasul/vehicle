using System;
using System.Collections.Generic;
using System.Text;

namespace vehicle.Models.Interfeys
{
    interface IEngine
    {
        public double HorsePower { get; set; }
        public double TankSize{ get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public void LeftFuelAmount() { }

    }
}
