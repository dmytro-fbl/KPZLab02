using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Devices
{
    public class BalaxyNetbook : INetbook
    {
        public string Name { get; set; }
        public double DisplaySize { get; set; }

        public BalaxyNetbook()
        {
            Name = "Balaxy A33 Ultra";
            DisplaySize = 5.5;
        }
        public BalaxyNetbook(string name, double displaySize)
        {
            Name = name;
            DisplaySize = displaySize;
        }
    }
}
