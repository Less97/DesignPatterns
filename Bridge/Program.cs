using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern:");
            Console.WriteLine("Using ImplementationA: "+new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine("Using ImplementationB: " + new Abstraction(new ImplementationB()).Operation());
            Console.ReadLine();
        }
    }
}
