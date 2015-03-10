using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    public class CreamDecorator : ICoffee
    {
        private ICoffee coffee;

        public CreamDecorator(ICoffee c)
        {
            coffee = c;
        }

        public string GetName()
        {
            return coffee.GetName() + " and Cream";
        }

        public decimal GetPrice()
        {
            return coffee.GetPrice() + 0.5m;
        }
    }
}
