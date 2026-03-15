using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Devices;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    public class BalaxyFactory : ICompanyFactory
    {
        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
        public INetbook CreateNetbook()
        {
            return new BalaxyNetbook();
        }
        public ILaptop CreateLaptop()
        {
            return new BalaxyLaptop();
        }
    }
}
