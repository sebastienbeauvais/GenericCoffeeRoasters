using GenericCoffeeRoasters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCoffeeRoasters.Entrance
{
    public class GenericCoffeeRoasters
    {
        private readonly IEnumerable<Beverage> _beverages;
        private readonly IEnumerable<CondimentDecorator> _condimentDecorator;
        public GenericCoffeeRoasters(IEnumerable<Beverage> beverages, IEnumerable<CondimentDecorator> condimentDecorators) 
        {
            _beverages = beverages;
            _condimentDecorator = condimentDecorators;
        }
        public void GreetCustomer()
        {
            Console.WriteLine("Welcome to Generic Coffee Roasters!\n");
            Console.WriteLine("Here are all of our offerings: \n");

            GetMenu();
        }
        private void GetMenu()
        {
            PrintMenuHeader();
            foreach (var beverage in _beverages)
            {
                Console.WriteLine($"{beverage.GetDescription()} - {beverage.Cost():F2}");

                foreach (var condiment in _condimentDecorator)
                {
                    var decoratedBeverage = (Beverage)Activator.CreateInstance(condiment.GetType(), beverage);
                    Console.WriteLine($"{decoratedBeverage.GetDescription()} - {decoratedBeverage.Cost():F2}");
                }
            }
            PrintMenuFooter();
        }
        private void PrintMenuHeader()
        {
            Console.WriteLine("===================== Generic Coffee Roasters =====================\n");
        }
        private void PrintMenuFooter()
        {
            Console.WriteLine("===================================================================\n");
        }
    }
}
