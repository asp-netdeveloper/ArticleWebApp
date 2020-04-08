using ArticleDN.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDN.Components
{
    public class MainMenu : ViewComponent
    {
        private readonly ArticleContext _context;

        public MainMenu(ArticleContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var menus = _context.Menus.OrderBy(p => p.MenuName);
            return View(menus);
        }
    }
}
