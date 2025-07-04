namespace E_CommereceSystem.CL.Models
{
    public class Cart
    {
        public List<(Product product, int quantity)> products = new List<(Product product, int quantity)>();
        public Cart() { }
        public void AddingNewProductToCart(Product product, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Please enter a posivie quantity");
            }
            if (product.IsExpired && product.ExpireDate < DateTime.Now)
            {
                throw new ArgumentException("This product is expired, Please order another one.");
            }
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].product.ID == product.ID)
                {
                    if(products[i].quantity + quantity > product.Quantity)
                    {
                        throw new ArgumentException("The required quantity is unavailable.");

                    }
                    products[i] = (product, products[i].quantity + quantity);
                    
                    return;
                }
            }
            if (quantity > product.Quantity)
            {
                throw new ArgumentException("The required quantity is unavailable.");

            }
            products.Add((product, quantity));
        }
    }
}
