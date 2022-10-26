using MarketPlace.Data.Enums;
using MarketPlace.Models;
using MarketPlace.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Controllers.V0
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("0.1")]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionsService _auctionService;
        private readonly ISortService _sortService;

        public AuctionsController(IAuctionsService auctionService, ISortService sortService)
        {
            _auctionService = auctionService;
            _sortService = sortService;
        }

        //[HttpGet]
        //public async Task<List<Sale>> Index()
        //{
        //    var sales = await _auctionService.GetAllSalesAsync();
        //    return sales;
        //}

        [HttpGet("catalog-items")]
        public PagedList<Sale> Index(int? page, int? limit, string? name, string? seller, MarketStatus? status, SortTypeOrder? sort_order, SortTypeKeys? sort_key)
        {
            var sales = _auctionService.GetAllSales(page, limit, name, seller, status);

            sales = (PagedList<Sale>)_sortService.Sort(sales, sort_order, sort_key);

            return sales;
        }

        [HttpGet]
        public Sale Index(int id)
        {
            var sales = _auctionService.GetSale(id);
            return sales;
        }
    }
}
