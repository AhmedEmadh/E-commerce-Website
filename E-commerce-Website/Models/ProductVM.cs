using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_commerce_Website.Models
{
    public class ProductVM
    {
        [Required]
        [MaxLength(20)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}
