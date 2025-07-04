namespace E_CommereceSystem.CL.Models
{
    public class Product
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public bool IsExpired { get; private set; }
        public bool ISrequiredShipping { get; private set; }
        public double Weight { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public int ID { get; private set; }

        public Product(string name, int quantity, double price, bool isExpired, DateTime? expireDate, bool isrequiredShipping, double weight, int id)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("please eneter a valid name.");
            }
            if (quantity <= 0)
            {
                throw new ArgumentException("please eneter a positive quantity.");

            }
            if (price <= 0)
            {
                throw new ArgumentException("please eneter a positive price.");

            }
            if (isExpired)
            {
                if (expireDate < DateTime.Now)
                {
                    throw new ArgumentException("please eneter a valid date.");
                }
            }
            if (isrequiredShipping)
            {
                if (weight <= 0)
                {
                    throw new ArgumentException("please eneter a valid weight.");

                }
            }
            if (id <= 0)
            {
                throw new ArgumentException("please eneter a valid id.");

            }
            Name = name;
            Quantity = quantity;
            Price = price;
            IsExpired = isExpired;
            ExpireDate = expireDate;
            ISrequiredShipping = isrequiredShipping;
            Weight = weight;
            ID = id;
        }
    }
}
