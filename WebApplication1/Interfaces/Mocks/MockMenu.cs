using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces.Mocks
{
    public class MockMenu : IMenu
    {
        public IEnumerable<Menu> AllMenu
        {
            get
            {
                return new List<Menu>{
                    new Menu { MenuName = "This" },
                    new Menu { MenuName = "And This"
                    } };
            }
        }
    }
}
