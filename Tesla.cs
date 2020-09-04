using System;

namespace GarysGarage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKHw { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your Tesla now charged to {this.BatteryKHw}KHw.");
        }

        public override void Drive()
        {
            Console.WriteLine("The red Tesla drives past. Zooooooom!");
        }
    }
}