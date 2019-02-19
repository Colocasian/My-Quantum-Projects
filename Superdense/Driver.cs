using System;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Superdense
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                foreach (int num in Enumerable.Range(0, 4))
                {
                    var check = SuperdenseCode.Run(qsim, (num & 1) != 0, (num & 2) != 0, 1000).Result;
                    Console.WriteLine($"Did it succeed with {num / 2}{num % 2}? {check}");
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
