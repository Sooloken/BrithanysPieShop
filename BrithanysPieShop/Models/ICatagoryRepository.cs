using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrithanysPieShop.Models
{
    public interface ICatagoryRepository
    {
        IEnumerable<Catagory> Catagories { get; }
    }
}
