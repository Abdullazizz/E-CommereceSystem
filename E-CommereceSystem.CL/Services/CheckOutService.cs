using E_CommereceSystem.CL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommereceSystem.CL.Services
{
    public class CheckOutService
    {

        // Customer.
        private readonly ShipmentService _shipmentService;
        public CheckOutService(ShipmentService shipmentService )
        {
            _shipmentService = shipmentService;

        }

        public void CheckOut(Customer customer)
        {
            double subtotal = 0, ShippingFees = 0;
            if (customer.Cart.products.Count == default)
            {
                throw new ArgumentException("The Cart is empty.");

            }
            List<ShippableProduct> shippableProduct = new List<ShippableProduct>();
            for (int i = 0; i < customer.Cart.products.Count; i++)
            {
                subtotal += customer.Cart.products[i].product.Price * customer.Cart.products[i].quantity;
                if (customer.Cart.products[i].product.ISrequiredShipping)
                {
                    ShippingFees += (customer.Cart.products[i].product.Weight * customer.Cart.products[i].quantity) / (2);
                    shippableProduct.Add(new ShippableProduct(customer.Cart.products[i].product.Name, customer.Cart.products[i].quantity, customer.Cart.products[i].product.Weight));

                }
            }
            if (subtotal + ShippingFees > customer.Balance)
            {
                throw new ArgumentException("The amount of money on the cart is not enough.");
            }
            if (shippableProduct.Count() != default)
            {
                _shipmentService.ShippingProcessing(shippableProduct);
            }
            Console.WriteLine("\n** Checkout receipt ** ");
            for (int i = 0; i < customer.Cart.products.Count; i++)
            {
                Console.Write(customer.Cart.products[i].quantity + "x ");
                Console.WriteLine(customer.Cart.products[i].product.Name + "  " + customer.Cart.products[i].product.Price * customer.Cart.products[i].quantity+ "$");

            }
            Console.WriteLine("\n***************");
            Console.WriteLine("Subtotal = " + subtotal + "$");
            Console.WriteLine("Shipping = " + ShippingFees + "$");
            Console.WriteLine("Amount = " + (subtotal + ShippingFees ) + "$");
        }
    }
}
