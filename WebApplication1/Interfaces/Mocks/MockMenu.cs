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
                    new Menu { MenuName = "This", Id = 1, Code = "", ParentId = 0, Status = 0 },
                    new Menu { MenuName = "And This", Id = 2, Code = "", ParentId = 1, Status = 0},
                    new Menu { MenuName = "And This", Id = 3, Code = "", ParentId = 1, Status = 0},
                    new Menu { MenuName = "And This", Id = 4, Code = "", ParentId = 1, Status = 0}
                };
            }
        }
    }
}
