using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy Pattern:");
            Proxy myProxy = new Proxy();
            //should not grant the access
            Console.WriteLine("Request Without access...");
            Console.WriteLine(myProxy.Request());
            //ask for authentication...Failed
            Console.WriteLine("Authentication answer: " + myProxy.Authenticate("wrongUser", "wrongPassword"));
            //Request Failed again
            Console.WriteLine("Request after failing access...");
            Console.WriteLine(myProxy.Request());
            //Request Granted...
            Console.WriteLine("Authentication answer: " + myProxy.Authenticate("user", "password"));
            Console.WriteLine("Request after granted access...");
            Console.WriteLine(myProxy.Request());
            Console.ReadLine();
        }
    }
}
