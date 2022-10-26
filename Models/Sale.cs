using MarketPlace.Data.Base;
using MarketPlace.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace.Models
{
    public class Sale : IEntityBase                
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public DateTime CreatedDt { get; set; }

        public DateTime FinishedDt { get; set; }

        public decimal Price { get; set; } 

        public MarketStatus Status { get; set; }

        public string Seller { get; set; }

        public string Buyer { get; set; }
    }
}
