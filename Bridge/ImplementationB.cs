using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ImplementationB : IBridge
    {
        public string Operation()
        {
            return "Operating with Implementation B";
        }
    }
}
