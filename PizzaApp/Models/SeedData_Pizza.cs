using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesPizza.Models
{
    public static class SeedData_Pizza
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesPizzaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesPizzaContext>>()))
            {
                if (context.Pizza.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pizza.AddRange(
                    new Pizza
                    {
                        PizzaName = "BBQ Chicken Pizza",
                        VisitDate = DateTime.Parse("2023-01-12"),
                        Category = "Non Veg",
                        PizzaSize = "9 inches",
                        Price = 10
                    },
                    new Pizza
                    {
                        PizzaName = "Hawaiian Pizza",
                        VisitDate = DateTime.Parse("2023-02-05"),
                        Category = "Non Veg",
                        PizzaSize = "10 inches",
                        Price = 12
                    },
                    new Pizza
                    {
                        PizzaName = "Pacific Veggie Pizza",
                        VisitDate = DateTime.Parse("2022-11-12"),
                        Category = "Veg",
                        PizzaSize = "12 inches",
                        Price = 12
                    },
                    new Pizza
                    {
                        PizzaName = "Cheese Pizza",
                        VisitDate = DateTime.Parse("2022-12-12"),
                        Category = "Veg",
                        PizzaSize = "7 inches",
                        Price = 8
                    },
                    new Pizza
                    {
                        PizzaName = "BBQ Chicken Cheese Pizza",
                        VisitDate = DateTime.Parse("2023-1-1"),
                        Category = "Non Veg",
                        PizzaSize = "9 inches",
                        Price = 11
                    }

                );
                context.SaveChanges();
            }
        }
    }
}