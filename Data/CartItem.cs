namespace easygroceries.Data
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal total
        {
            get { return Quantity * Price; }

        }
        public CartItem() { }

        public CartItem(int productId, string productName, int quantity, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            Quantity = 1;
            Price = price;
        }
    }

}
