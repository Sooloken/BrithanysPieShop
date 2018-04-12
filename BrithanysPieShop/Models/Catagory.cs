using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrithanysPieShop.Models
{
    public class Catagory
    {
        public int CatagoryID { get; set; }

        public string CatagoryName { get; set; }

        public string Description { get; set; }

        public List<Pie> Pies { get; set; }

    }
}
