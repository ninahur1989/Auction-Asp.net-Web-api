using MarketPlace.Data.Enums;
using Sieve.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketPlace.Models
{
    public class Sale 
    {
        [Key]
        public int Id { get; set; }

        public virtual int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public DateTime CreatedDt { get; set; }

        public DateTime FinishedDt { get; set; }

        [Sieve(CanFilter = true, CanSort = true)]
        public decimal Price { get; set; }

        public MarketStatus Status { get; set; }

        public string Seller { get; set; }

        public string Buyer { get; set; }
    }
}
