using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Decorators;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new Coffee();
            Console.WriteLine(coffee.GetName()+": "+coffee.GetPrice());
            var chocolateDecorator = new ChocolateDecorator(coffee);
            Console.WriteLine(chocolateDecorator.GetName()+": "+chocolateDecorator.GetPrice());
            var creamChocolateDecorator = new CreamDecorator(chocolateDecorator);
            Console.WriteLine(creamChocolateDecorator.GetName()+": "+creamChocolateDecorator.GetPrice());
            Console.ReadLine();
        }
    }
}
