using Shop.Areas.Admin.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Order.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public decimal TotalCost { get; set; }
        public bool IsClose { get; set; }

        public User User { get; set; }
    }
}
