using GenericCoffeeRoasters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
                Console.WriteLine($"{beverage.GetDescription()} - ${beverage.Cost():F2}");

                GenerateMenuCombinations(beverage, _condimentDecorator.ToList(), 0);
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
        private void GenerateMenuCombinations(Beverage beverage, List<CondimentDecorator> condiments, int index)
        {
            for (int i = index; i < condiments.Count; i++)
            {
                Beverage decoratedBeverage = (Beverage)Activator.CreateInstance(condiments[i].GetType(), beverage);
                Console.WriteLine($"{decoratedBeverage.GetDescription()} - ${decoratedBeverage.Cost():F2}");

                // Recursively apply more condiments
                GenerateMenuCombinations(decoratedBeverage, condiments, i + 1);
            }
        }
    }
}
