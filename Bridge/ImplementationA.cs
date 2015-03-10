using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ImplementationA : IBridge
    {
        public string Operation()
        {
            return "Operating with Implementation A";
        }
    }
}
