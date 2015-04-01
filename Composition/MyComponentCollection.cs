using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class MyComponentCollection : IComponent
    {
        public string Name { get; set; }

        private List<IComponent> components = new List<IComponent>();

        public MyComponentCollection(String name)
        {
            Name = name;
        }

        public void Display()
        {
            foreach (var component in components)
            {
                component.Display();
            }
        }

        public IComponent Add(IComponent component)
        {
           components.Add(component);
            return this;
        }

        public IComponent Remove(IComponent component)
        {
            var componentToRemove = components.FirstOrDefault(c => c.Name == component.Name);
            if (componentToRemove != null)
            {
                components.RemoveAt(components.IndexOf(componentToRemove));
            }
            return this;
        }

       
    }
}
