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

        public AuctionsController(IAuctionsService auctionService)
        {
            _auctionService = auctionService;
        }

        //[HttpGet]
        //public async Task<List<Sale>> Index()
        //{
        //    var sales = await _auctionService.GetAllSalesAsync();
        //    return sales;
        //}

        [HttpGet]
        public async Task<Sale> Index(int id)
        {
            var sales = await _auctionService.GetSaleAsync(id);
            return sales;
        }
    }
}
