using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface ICoffee
    {
        String GetName();
        Decimal GetPrice();
    }


}
