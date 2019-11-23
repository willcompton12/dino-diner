using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> category { get; set; } = new List<string>();

        [BindProperty]
        public double? minimumPrice { get; set; }

        [BindProperty]
        public double? maximumPrice { get; set; }

        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        public List<IMenuItem> items { get; set; }

        public Menu menu { get; protected set; }


        public List<IMenuItem> entrees
        {
            get
            {
                List<IMenuItem> entrees = new List<IMenuItem>();
                foreach(IMenuItem m in items)
                {
                    if(m is Entree)
                    {
                        entrees.Add(m);
                    }
                }

                return entrees;
            }
        }
        public List<IMenuItem> sides
        {
            get
            {
                List<IMenuItem> sides = new List<IMenuItem>();
                foreach(IMenuItem m in items)
                {
                    if(m is Side)
                    {
                        sides.Add(m);
                    }
                }
                return sides;
            }
        }

        public List<IMenuItem> drinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();
                foreach(IMenuItem m in items)
                {
                    if(m is Drink)
                    {
                        drinks.Add(m);
                    }
                }
                return drinks;
            }
        }
        public List<CretaceousCombo> combos
        {
            get
            {
                List<CretaceousCombo> combos = new List<CretaceousCombo>();
                foreach(IMenuItem m in items)
                {
                    if(m is CretaceousCombo)
                    {
                        combos.Add((CretaceousCombo)m);
                    }
                }
                return combos;
            }
        }
        public void OnGet()
        {
            menu = new Menu();
            items = menu.AvailableMenuItems;
        }

        public void OnPost()
        {
            menu = new Menu();
            items = menu.AvailableMenuItems;

            if(search != null)
            {
                items = menu.Search(items, search);
            }

            if(category.Count != 0)
            {
                items = menu.FilterByCategory(items, category);
            }

            if(minimumPrice != null)
            {
                items = menu.FilterByMinPrice(items, minimumPrice);
            }
            if(maximumPrice != null)
            {
                items = menu.FilterByMaxPrice(items, maximumPrice);
            }
            if(ingredients.Count != 0)
            {
                items = menu.FilterByIngredients(items, ingredients);
            }

        }
    }
}