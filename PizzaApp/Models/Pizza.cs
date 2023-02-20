using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPizza.Models
{
    public class Pizza
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string PizzaName { get; set; }
    

        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }
        public string Category { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string PizzaSize { get; set; }

        [Range(1, 2000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(4, 3)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Topping { get; set; }
        public string Rating { get; set; }
        public int Discount { get; set; }

    }
}