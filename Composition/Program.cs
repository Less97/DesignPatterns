using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            MyComponentCollection myCollection = new MyComponentCollection("Root");
            Component c1 = new Component("C1");
            Component c2 = new Component("C2");
            MyComponentCollection cc3 = new MyComponentCollection("CC3");
            cc3.Add(new Component("CC3-1"));
            cc3.Add(new Component("CC3-2"));
            myCollection.Add(c1).Add(c2).Add(cc3);
            myCollection.Display();
            Console.ReadLine();
        }
    }
}
