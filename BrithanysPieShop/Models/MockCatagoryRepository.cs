using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrithanysPieShop.Models
{
    public class MockCatagoryRepository : ICatagoryRepository

    {
        public IEnumerable<Catagory> Catagories
        {
            get
            {
                return new List<Catagory>
                {
                    new Catagory{CatagoryID=1 ,CatagoryName="Fruit pies", Description="All-fruity pies" },
                    new Catagory{CatagoryID=2 ,CatagoryName="Cheese cakes", Description="Chessy all the way"},
                    new Catagory{CatagoryID=3 ,CatagoryName="Seasonal pies", Description="Get in the mood for te season"}
                };
            }
        }
    } 
}
