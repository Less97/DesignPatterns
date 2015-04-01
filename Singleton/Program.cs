using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton s1 = MySingleton.Instance;
            MySingleton s2 = MySingleton.Instance;
            if(s1==s2)
                Console.WriteLine("s1 and s2 are equal");
            Console.ReadLine();

        }
    }
}
