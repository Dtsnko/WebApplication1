using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string MenuName { get; set; }
        public int ParentId { get; set; }
        public int Status { get; set; }
    }
}
