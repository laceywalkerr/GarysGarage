using System;
using System.Collections.Generic;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            fxs.Drive();

            List<Zero> electricVehicles = new List<Zero>() { fxs, fxs };
        }
    }
}