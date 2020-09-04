using System;

namespace GarysGarage
{
    public class Zero : Vehicle
    {
        public double BatteryKHw { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla now charged to {this.BatteryKHw}KHw.");
        }
    }
}