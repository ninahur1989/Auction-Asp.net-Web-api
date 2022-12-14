using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Metadata { get; set; }
    }
}
