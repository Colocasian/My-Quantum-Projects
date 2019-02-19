using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Crypt
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                var hackd = true;
                var bola = CryptSend.Run(qsim, 8, hackd).Result;
                var safe = true;

                foreach (var x in bola)
                {
                    if (x == -2)
                    {
                        safe = false;
                        Console.WriteLine("We have been hacked!");
                        break;
                    }
                }

                if (safe)
                {
                    Console.Write("Secret Key: ");
                    foreach (var x in bola)
                    {
                        if (x != -1)
                        {
                            Console.Write(x);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Were we actually hacked? {hackd}");
            }

            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
