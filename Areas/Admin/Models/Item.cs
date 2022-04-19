using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Admin.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public int QuntityInStock { get; set; }
        public decimal Cost { get; set; }

        public Product Product { get; set; }
    }
}
