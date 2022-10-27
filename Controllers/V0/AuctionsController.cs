using MarketPlace.Data.Enums;
using MarketPlace.Models;
using MarketPlace.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarketPlace.Controllers.V0
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("0.1")]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionsService _auctionService;
        private readonly ISortService _sortService;
        private readonly ILogger<AuctionsController> _logger;

        public AuctionsController(IAuctionsService auctionService, ISortService sortService, ILogger<AuctionsController> logger)
        {
            _auctionService = auctionService;
            _sortService = sortService;
            _logger = logger;
        }

        //for swagger
        [HttpGet("catalog-items")]
        public PagedList<Sale> Index(int? page, int? limit, string? name, string? seller, MarketStatus? status, SortTypeOrder? sort_order, SortTypeKeys? sort_key)
        {
            _logger.LogInformation("entered to Index");
            var sales = _auctionService.GetAllSales(page, limit, name, seller, status);

            sales = (PagedList<Sale>)_sortService.Sort(sales, sort_order, sort_key);

            return sales;
        }

        [HttpGet]
        public Sale Index(int id)
        {
            var sales = _auctionService.GetSaleById(id);
            return sales;
        }
    }
}
