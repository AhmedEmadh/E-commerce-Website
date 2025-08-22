namespace E_commerce_Website.Models
{
    public class IndexDM
    {
        public IndexDM()
        {
            Categories = new List<Category>();
            Products = new List<Product>();
            Reviews = new List<Review>();
        }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public Cart? Cart { get; set; }
        public ReviewVM ReviewVM { get; set; } = new ReviewVM();
    }
}
