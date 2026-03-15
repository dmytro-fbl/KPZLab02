using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    public interface ICompanyFactory
    {
        public ISmartphone CreateSmartphone();
        public INetbook CreateNetbook();
        public ILaptop CreateLaptop();
    }
}
