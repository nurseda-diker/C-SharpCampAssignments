using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi"+customer.Name); 
        }
        public void CustomerList(Customer[] customers)
        {
            foreach(var customer in customers)
            {
                Console.WriteLine("Müşteriler listelendi" + customer.Name);
            }
            
            
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Müşteri silindi" + customer.Name);
        }
    }
}
