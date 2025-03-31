using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Models
{
    public abstract class Beverage 
    {
        protected string description = "Unknown Beverage";
        public virtual string GetDescription() => description;
        public abstract double Cost();
    }
}
