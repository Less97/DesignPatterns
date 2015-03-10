using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class ChocolateDecorator : ICoffee
    {
        private ICoffee coffee;
        public ChocolateDecorator(ICoffee c)
        {
            this.coffee = c;
        }

        public string GetName()
        {
            return coffee.GetName() + " with Chocolate";
        }

        public decimal GetPrice()
        {
            return coffee.GetPrice() + 1.0m;
        }
    }
}
