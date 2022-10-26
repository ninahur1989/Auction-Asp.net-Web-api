using MarketPlace.Data;
using MarketPlace.Models;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using MarketPlace.Data.Enums;

namespace MarketPlace.Services
{
    public class AuctionsService : IAuctionsService
    {
        private readonly ApplicationContext _context;
        public AuctionsService(ApplicationContext context)
        {
            _context = context;
        }


        public Sale GetSale(int id)
        {
            var item = _context.Sales.FirstOrDefault(x => x.Item.Id == id);
            return item;
        }

        public PagedList<Sale> GetAllSales(int? page, int? limit, string? name, string? seller, MarketStatus? status)
        {
            if (page < 1 || page == null)
            {
                page = 1;
            }
            if (limit < 1 || limit == null)
            {
                limit = 10;
            }

            name = name ?? string.Empty;
            seller = seller ?? string.Empty;


            if (status == null)
            {
                var sales = _context.Sales.Where(x => x.Item.Name.Contains(name) && x.Seller.StartsWith(seller)).Skip((int)((page - 1) * limit)).Take((int)limit).ToList();
                var pagedSales = PagedList<Sale>.ToPagedList(sales, (int)page, (int)limit, _context.Sales.Count());
                return pagedSales;
            }
            else
            {
                var sales = _context.Sales.Where(x => x.Item.Name.Contains(name) && x.Status == status && x.Seller.StartsWith(seller)).Skip((int)((page - 1) * limit)).Take((int)limit).ToList();
                var pagedSales = PagedList<Sale>.ToPagedList(sales, (int)page, (int)limit, _context.Sales.Count());
                return pagedSales;
            }
        }
    }
}
