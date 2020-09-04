using System;

namespace GarysGarage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"Your Cessna now refuled to {this.FuelCapacity}.");
        }
        public override void Drive()
        {
            Console.WriteLine("The white Cessna drives past. Rrrrrrumble!");
        }

    }
}