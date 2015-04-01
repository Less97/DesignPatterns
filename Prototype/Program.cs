using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype1 cp1 = new ConcretePrototype1("CP1");
            ConcretePrototype1 pc1 = (ConcretePrototype1) cp1.Clone();
            Console.WriteLine("{0}",pc1.Id);
            ConcretePrototype1 cp2 = new ConcretePrototype1("CP2");
            ConcretePrototype1 pc2 = (ConcretePrototype1)cp2.Clone();
            Console.WriteLine("{0}", pc2.Id);
            Console.ReadLine();
        }
    }
}
