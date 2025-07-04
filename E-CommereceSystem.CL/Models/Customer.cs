using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommereceSystem.CL.Models
{
    public class Customer
    {
        public Customer(string name, string address, double balance, string mobileNumber )
        {
            if (string.IsNullOrEmpty(name)){
                throw new ArgumentNullException("Please eneter a valid name.");
            }
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException("Please enter a valid address.");

            }
            if(balance < 0)
            {
                throw new ArgumentException("Please enter a postivie balance.");

            }
            if(string.IsNullOrEmpty(mobileNumber) || mobileNumber.Length < 11) {
                throw new ArgumentException("please enter a valid egyptian number.");
            }
            Name = name;
            Address = address;
            Balance = balance;
            MobileNumber = mobileNumber;
            Cart = new Cart();
        }
        public Cart Cart { get; set; }

        public string Name { get; private set; }
        public string Address { get; private set; }
        public double Balance { get; private set; }
        public string MobileNumber { get; private set; }

    }
}
