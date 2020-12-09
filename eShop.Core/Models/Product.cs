namespace eShop.Core.Models
{
    public class Product
    {
        public string Brand { get; set; }
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}