using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Devices;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    public class IproneFactory : ICompanyFactory
    {
        public ILaptop CreateLaptop()
        {
            return new IProneLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new IProneNetBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IProneSmartphone();
        }
    }
}
