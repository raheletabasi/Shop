using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Areas.Admin.Models
{
    public class ProductGroup
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }

        public List<Product> Product { get; set; }
        public List<Group> Groups { get; set; }

    }
}
