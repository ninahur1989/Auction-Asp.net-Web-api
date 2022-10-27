using MarketPlace.Data.Enums;
using MarketPlace.Models;

namespace MarketPlace.Services
{
    public interface IAuctionsService
    {
        Sale GetSaleById(int id);

        PagedList<Sale> GetAllSales(int? page, int? limit, string? name, string? seller, MarketStatus? status);
    }
}
