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
        public Menu menu { get; protected set; }
        public List<IMenuItem> entrees
        {
            get
            {
                return menu.AvailableEntrees;
            }
        }
        public List<IMenuItem> sides
        {
            get
            {
                return menu.AvailableSides;
            }
        }

        public List<IMenuItem> drinks
        {
            get
            {
                return menu.AvailableDrinks;
            }
        }
        public List<CretaceousCombo> combos
        {
            get
            {
                return menu.AvailableCombos;
            }
        }
        public void OnGet()
        {
            menu = new Menu();
        }
    }
}