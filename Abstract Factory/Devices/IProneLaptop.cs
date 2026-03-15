using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Devices
{
    public class IProneLaptop : ILaptop
    {
        public string Name { get; set; }

        public int RamSize { get; set; }

        public IProneLaptop()
        {
            Name = "Mackbook 13 d";
            RamSize = 16;
        }
        public IProneLaptop(string name, int ramSize)
        {
            Name = name;
            RamSize = ramSize;
        }
    }
}
