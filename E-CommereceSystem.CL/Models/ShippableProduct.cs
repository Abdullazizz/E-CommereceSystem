namespace E_CommereceSystem.CL.Models
{
    public class ShippableProduct : IShippable
    {
        public string Name;
        public int Quantity;
        public double Weight;

        public ShippableProduct(string name, int quantity, double weight)
        {
            Name = name;
            Quantity = quantity;
            Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
        public int GetQuantity()
        {
            return Quantity;
        }

    }
}
