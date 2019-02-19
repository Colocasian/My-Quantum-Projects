using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Teleportation
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var res = doTeleport.Run(qsim, Result.Zero, true, 1000).Result;
                Console.WriteLine($"Did we succeed? {res}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
