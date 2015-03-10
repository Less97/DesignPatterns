using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraction
    {
        private IBridge myImplementation;

        public Abstraction(IBridge bridge)
        {
            myImplementation = bridge;
        }

        public String Operation()
        {
            return myImplementation.Operation();
        }

    }
}
