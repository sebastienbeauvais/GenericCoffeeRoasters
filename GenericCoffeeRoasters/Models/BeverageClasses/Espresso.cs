using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Models.BeverageClasses
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 1.09;
        }
    }
}
