using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCPU
{
    internal class Program
    {
        static string[] s =
        {
            "MOV r1,10",
            "SUB r1,5",
            "PRNT r1",
            "ADD r1,62",
            "PRNT r1"
        };

        static void Main(string[] args)
        {
            CPU cpu = new CPU();
            cpu.Run(s);

            Console.ReadKey();
        }
    }
}