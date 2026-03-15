using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Devices
{
    public class IProneSmartphone : ISmartphone
    {
        public string Name { get; set; }
        public int BatteryCapacity { get; set; }

        public IProneSmartphone(string name, int batteryCapacity)
        {
            Name = name;
            BatteryCapacity = batteryCapacity;
        }

        public IProneSmartphone()
        {
            Name = "IProne 12 Pro";
            BatteryCapacity = 4500;
        }
    }
}
