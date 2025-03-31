using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Models
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }
    }
}
