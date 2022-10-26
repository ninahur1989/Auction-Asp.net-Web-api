using MarketPlace.Data.Enums;
using MarketPlace.Models;
using System.Collections.Generic;

namespace MarketPlace.Services
{
    public interface ISortService
    {
        public IEnumerable<Sale> Sort(List<Sale> list, SortTypeOrder? sort_order, SortTypeKeys? sortType);
    }
}
