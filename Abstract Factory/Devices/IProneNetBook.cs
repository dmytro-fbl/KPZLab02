using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Devices
{
    public class IProneNetBook : INetbook
    {
        public string Name { get; set; }
        public double DisplaySize { get; set; }

        public IProneNetBook()
        {
            Name = "IProne Pro Max";
            DisplaySize = 5.9;
        }
        public IProneNetBook(string name, double displaySize)
        {
            Name = name;
            DisplaySize = displaySize;
        }
    }
}
