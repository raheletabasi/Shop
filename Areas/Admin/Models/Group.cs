using System.ComponentModel.DataAnnotations;

namespace Shop.Areas.Admin.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
