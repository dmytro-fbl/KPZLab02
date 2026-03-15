using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Devices
{
    public class BalaxySmartphone : ISmartphone
    {
        public string Name { get; set; }
        public int BatteryCapacity { get; set; }

        public BalaxySmartphone(string name, int batteryCapacity)
        {
            Name = name;
            BatteryCapacity = batteryCapacity;
        }

        public BalaxySmartphone()
        {
            Name = "Balaxy S12";
            BatteryCapacity = 5000;
        }
    }
}
