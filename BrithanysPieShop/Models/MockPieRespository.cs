using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrithanysPieShop.Models
{
    public class MockPieRespository : IPieRepository
    {
        private readonly ICatagoryRepository _categoryrespository = new MockCatagoryRepository();

        public IEnumerable<Pie> Pies
        {
            get
            {
                return new List<Pie>
                {
                    new  Pie {PieId =1, Name="Strawberry Pie", Price = 15.95M, ShortDescription="Nice Pie",AllergyInformation="gluten Free"},
                    new  Pie {PieId =2, Name="Cookie Pie", Price = 25.95M, ShortDescription="Not Nice Pie",AllergyInformation="Laktos Free"}

                };
        }
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
