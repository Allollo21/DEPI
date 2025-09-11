namespace ProjectOne.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

        // Calculated property (not mapped)
        public decimal TotalPrice => Quantity * (Product?.Price ?? 0);
    }
}
