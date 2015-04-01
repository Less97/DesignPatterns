using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Prototype
    {
        public String Id { get; set; }

        public Prototype(String id)
        {
            Id = id;
        }

        public abstract Prototype Clone();

    }
}
