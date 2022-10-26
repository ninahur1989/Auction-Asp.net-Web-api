using MarketPlace.Data;
using MarketPlace.Models;
using System.Threading.Tasks;
using System.Linq;
using MarketPlace.Data.Base;
using System.Collections.Generic;
using MarketPlace.Models.Enums;
using MarketPlace.Data.Enums;

namespace MarketPlace.Services
{
    public class AuctionsService : EntityBaseRepository<Sale>/*, IAuctionsService*/
    {
        public AuctionsService(ApplicationContext context) : base(context)
        {
        }

        public async Task<Sale> GetSaleAsync(int id)
        {
            var item = await GetByIdAsync(id, x => x.Item);
            return item;
        }

        public async Task<List<Sale>> GetAllSalesAsync(string? name, string? seller, MarketStatus? status, SortTypeOrder? sort_order, SortTypeKeys? sort_key)
        {
            if (status == null)
            {
                status = MarketStatus.None;
            }

            var items = await GetAllAsync(x => x.Item.Name.Contains(name) && x.Status == status && x.Seller.StartsWith(seller));




            return (List<Sale>)items;
        }
    }
}
