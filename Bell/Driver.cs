using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            var estimator = new ResourcesEstimator();
            BellTest.Run(estimator, 1000, Result.Zero).Wait();

            System.Console.WriteLine(estimator.ToTSV());

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
