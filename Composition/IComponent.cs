using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public interface IComponent
    {
        String Name { get; set; }

        void Display();

        IComponent Add(IComponent component);

        IComponent Remove(IComponent component);
    }
}
