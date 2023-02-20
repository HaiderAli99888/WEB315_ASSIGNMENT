using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string PizzaName { get; set; }
    

        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }
        public string Category { get; set; }
        public string PizzaSize { get; set; }
        public decimal Price { get; set; }

        public string Topping { get; set; }
        public string Rating { get; set; }
        public int Discount { get; set; }

    }
}