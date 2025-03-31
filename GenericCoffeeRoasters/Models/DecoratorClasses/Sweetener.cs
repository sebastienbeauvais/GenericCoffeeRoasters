using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Models.DecoratorClasses
{
    public class Sweetener : CondimentDecorator
    {
        public Sweetener(Beverage beverage) 
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + " Sweetener";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.35;
        }
    }
}
