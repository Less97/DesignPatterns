using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Coffee : ICoffee
    {
        public String GetName()
        {
            return "Coffee";
        }

        public Decimal GetPrice()
        {
            return 2.0m;
        }
    }
}
