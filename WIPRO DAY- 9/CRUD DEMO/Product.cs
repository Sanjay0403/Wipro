using System.ComponentModel.DataAnnotations;

namespace CRUDRazorDemousingFF.Models
{
    public class Product
    {
        [Key]
        public int ProId { get; set; }
        public string ProName { get; set; }
        public string ProDescription { get; set; }
    }
}
