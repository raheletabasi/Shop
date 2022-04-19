using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Areas.Admin.Models
{
    public class ProductGroup
    {     
        public int ProductId { get; set; }
        public int GroupId { get; set; }

        public Product Product { get; set; }
        public Group Groups { get; set; }

    }
}
