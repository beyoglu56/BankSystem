using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_System
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Customer Added! Dear customer, welcome to our bank  Information:" + customer.CustomerAdi +  customer.CustomerSoyadi + "-------" + customer.CustomerId + "-----" +
            customer.CustomerHesapTürü + "-------" + customer.CustomerHesaptakiPara + "TL" );
        }




        public void CustomerList(Customer customer)
        {
            Customer[] customers = new Customer[] { customer };
            foreach (Customer customer1 in customers)
            {
                Console.WriteLine("Customer Information: "+ customer.CustomerAdi +  customer.CustomerSoyadi + "----" + customer.CustomerId + "----" +
            customer.CustomerHesapTürü + "--------" + customer.CustomerHesaptakiPara + "TL");
            }


        }


        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer was deleted!" ); 
        }










    }
}
