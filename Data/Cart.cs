namespace easygroceries.Data
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal
        {
            get; set;
        }
    }
}
