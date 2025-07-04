using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
