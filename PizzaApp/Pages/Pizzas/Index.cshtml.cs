using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPizza.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PizzaApp.Pages_Pizzas
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPizzaContext _context;

        public IndexModel(RazorPagesPizzaContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }
       
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Categories { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CategoryName { get; set; }

        public async Task OnGetAsync()
        {

            IQueryable<string> categoryQuery = from t in _context.Pizza
                                            orderby t.Category
                                            select t.Category;

           var pizzas = from p in _context.Pizza select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                pizzas = pizzas.Where(s => s.PizzaName.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(CategoryName))
            {
                pizzas = pizzas.Where(x => x.Category == CategoryName);
            }
            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());

            Pizza = await pizzas.ToListAsync();
        }
    }
}
