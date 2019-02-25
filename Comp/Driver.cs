using System;
using System.Linq;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Comp
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var answer = BernsteinVarzani.Run(qsim, 8).Result;
                foreach (var i in Enumerable.Range(0, 8))
                {
                    Console.WriteLine($"Was position {i} on? {(answer[i]? 1 :0)}");
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
