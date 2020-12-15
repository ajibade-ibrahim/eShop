namespace eShop.Core.Models
{
    public class OrderLineItem
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}