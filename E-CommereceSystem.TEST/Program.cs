using E_CommereceSystem.CL.Models;
using E_CommereceSystem.CL.Services;

namespace E_CommereceSystem.TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Abdulaziz", "Maadi", 6000, "01142183115");
            List<Product> products = new List<Product> {
             new Product("Cheese", 5, 10, true, DateTime.Now.AddDays(5), true, 10 , 1) ,
             new Product ("Biscuits" , 5 , 4 , true , DateTime.Now.AddDays(10) , false, default, 2),
             new Product ("TV" , 10, 100, false, null, true, 20 , 3),
             new Product("Mobile" , 20, 50, false, null, false,default , 4),
            };
            customer.Cart.AddingNewProductToCart(products[0], 2);
            customer.Cart.AddingNewProductToCart(products[1], 4);
            customer.Cart.AddingNewProductToCart(products[2], 5);
            customer.Cart.AddingNewProductToCart(products[3], 10);
            CheckOutService checkOutService = new CheckOutService(new ShipmentService());
            checkOutService.CheckOut(customer);
            Console.ReadKey();
        }

    }
}
