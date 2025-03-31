using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Models.DecoratorClasses
{
    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Steamed Milk";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.90;
        }
    }
}
