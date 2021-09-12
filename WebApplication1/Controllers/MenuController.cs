using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.ViewModels;

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
            MenuListViewModel list = new MenuListViewModel();
            list.allMenu = _AllMenu.AllMenu;
            return View(list);
        }
        public ViewResult Ending(Menu tempMenu)
        {
            MenuListViewModel list = new MenuListViewModel();
            list.allMenu.ToList().Add(tempMenu);
            return View(list.MenuName);
        }

    }
}
