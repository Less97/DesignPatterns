using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Component : IComponent
    {
        public string Name { get; set; }

        public Component(String name)
        {
            Name = name;
        }

        public void Display()
        {
           Console.WriteLine(String.Format("Component: {0}",Name));
        }

        public IComponent Add(IComponent component)
        {
            Console.WriteLine("You cannot add a component to another component");
            return this;
        }

        public IComponent Remove(IComponent component)
        {
            Console.WriteLine("You cannot remove a component to another component");
            return this;
        }
    }
}
