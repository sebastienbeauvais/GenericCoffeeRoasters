using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Models.DecoratorClasses
{
    public class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage) : base(beverage) { }
        public override string GetDescription()
        {
            return beverage.GetDescription() + " Cream";
        }
        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }
    }
}
