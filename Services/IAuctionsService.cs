using MarketPlace.Data.Base;
using MarketPlace.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Services
{
    public interface IAuctionsService : IEntityBaseRepository<Sale>
    {
        Task<Sale> GetSaleAsync(int id);

        Task<List<Sale>> GetAllSalesAsync();
    }
}
