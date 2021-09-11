using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenu _AllMenu;

        public MenuController(IMenu iMenu)
        {
            _AllMenu = iMenu;
        }
        public ViewResult List()
        {
            var menu = _AllMenu.AllMenu;
            return View(menu);
        }

    }
}
