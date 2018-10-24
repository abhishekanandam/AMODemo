using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatternsDemo.FactoryDemo.AbstractFactory.Enumerations;

namespace DesignPatternsDemo.FactoryDemo.AbstractFactory
{
    class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.Dell.ToString();
        }
    }
}
