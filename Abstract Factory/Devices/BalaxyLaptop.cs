using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Devices
{
    public class BalaxyLaptop : ILaptop
    {
        public string Name { get; set; }

        public int RamSize { get; set; }

        public BalaxyLaptop()
        {
            Name = "Sumcung Balaxy 13A";
            RamSize = 16;
        }
        public BalaxyLaptop(string name, int ramSize)
        {
            Name = name;
            RamSize = ramSize;
        }
    }
}
