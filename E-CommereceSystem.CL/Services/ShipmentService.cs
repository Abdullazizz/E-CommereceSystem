using E_CommereceSystem.CL.Models;

namespace E_CommereceSystem.CL.Services
{
    public class ShipmentService
    {
        public void ShippingProcessing(List<ShippableProduct> shippableProducts)
        {
            double TotalPackageWeight = 0;
            Console.WriteLine("**  Shipment notice  **");
            for (int i = 0; i < shippableProducts.Count; i++)
            {
                Console.Write(shippableProducts[i].GetQuantity() + "X  ");
                Console.Write(shippableProducts[i].GetName() + "      ");
                Console.WriteLine(shippableProducts[i].GetWeight() * shippableProducts[i].GetQuantity() + "g");
                TotalPackageWeight += shippableProducts[i].GetWeight() * shippableProducts[i].GetQuantity();
            }
            Console.WriteLine("Total package weight = " + TotalPackageWeight / 1000 + "kg");
        }

    }
}
