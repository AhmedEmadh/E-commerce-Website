using System.ComponentModel.DataAnnotations;

namespace E_commerce_Website.Models
{
    public class OrderVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
