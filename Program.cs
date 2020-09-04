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
            Cessna mx410 = new Cessna();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();

            List<Zero> electricVehicles = new List<Zero>() { fxs, fxs };
        }
    }
}