
using MarketPlace.Data.Enums;
using MarketPlace.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Services
{
    public interface IAuctionsService
    {
        Sale GetSale(int id);

        PagedList<Sale> GetAllSales(int? page, int? limit, string? name, string? seller, MarketStatus? status);
    }
}
