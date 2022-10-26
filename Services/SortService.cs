using MarketPlace.Data.Enums;
using MarketPlace.Services;
using MarketPlace.Models;
using System.Collections.Generic;

namespace MarketPlace.Services
{
    public class SortService : ISortService
    {
        public IEnumerable<Sale> Sort(List<Sale> list, SortTypeOrder? sortOrder, SortTypeKeys? sortType)
        {
            switch (sortType)
            {
                case SortTypeKeys.Price:
                    list.Sort(delegate (Sale x, Sale y)
                    {
                        return x.Price.CompareTo(y.Price);
                    });

                    if (sortOrder.HasValue && sortOrder == SortTypeOrder.Descending)
                    {
                        list.Reverse();
                    }

                    break;

                case SortTypeKeys.CreatedDt:
                    list.Sort(delegate (Sale x, Sale y)
                    {
                        return x.Price.CompareTo(y.Price);
                    });

                    if (sortOrder.HasValue && sortOrder == SortTypeOrder.Descending)
                    {
                        list.Reverse();
                    }
                    break;

                default:
                    break;
            }
            return list;
        }
    }
}
