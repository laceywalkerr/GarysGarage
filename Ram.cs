using System;

namespace GarysGarage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"Your Cessna now refuled to {this.FuelCapacity}KHw.");
        }
    }
}