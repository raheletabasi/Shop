using Shop.Areas.Admin.Models;
using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Order.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public decimal Cost { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
