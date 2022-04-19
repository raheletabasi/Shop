using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Admin.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public Item Item { get; set; }
    }
}
