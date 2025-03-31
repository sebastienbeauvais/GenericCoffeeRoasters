using Microsoft.Extensions.DependencyInjection;
using GenericCoffeeRoasters;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();

            var greeterBot = serviceProvider.GetRequiredService<GenericCoffeeRoasters.Entrance.GenericCoffeeRoasters>();

            greeterBot.GreetCustomer();

        }
        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<GenericCoffeeRoasters.Entrance.GenericCoffeeRoasters, GenericCoffeeRoasters.Entrance.GenericCoffeeRoasters>();
            services.AddScoped<GenericCoffeeRoasters.Models.Beverage, GenericCoffeeRoasters.Models.BeverageClasses.Espresso>();
            services.AddScoped<GenericCoffeeRoasters.Models.Beverage, GenericCoffeeRoasters.Models.BeverageClasses.HouseBlend>();
            services.AddScoped<GenericCoffeeRoasters.Models.CondimentDecorator, GenericCoffeeRoasters.Models.DecoratorClasses.Mocha>();
            services.AddScoped<GenericCoffeeRoasters.Models.CondimentDecorator, GenericCoffeeRoasters.Models.DecoratorClasses.Cream>();
            services.AddScoped<GenericCoffeeRoasters.Models.CondimentDecorator, GenericCoffeeRoasters.Models.DecoratorClasses.SteamedMilk>();
            services.AddScoped<GenericCoffeeRoasters.Models.CondimentDecorator, GenericCoffeeRoasters.Models.DecoratorClasses.Sweetener>();

            return services.BuildServiceProvider();
        }
    }
}
