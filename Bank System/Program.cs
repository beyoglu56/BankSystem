using System;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.CustomerAdi = "Kadir";
            customer1.CustomerSoyadi = "Özer";
            customer1.CustomerId = 4;
            customer1.CustomerHesapTürü = "Kredi";
            customer1.CustomerHesaptakiPara = 1000;

            Customer customer2 = new Customer();
            customer2.CustomerAdi = "Recep";
            customer2.CustomerSoyadi = "Batak";
            customer2.CustomerId = 12;
            customer2.CustomerHesapTürü = "Döviz";
            customer1.CustomerHesaptakiPara = 0;

            Customer customer3 = new Customer();
            customer3.CustomerAdi = "Rabia";
            customer3.CustomerSoyadi = "Güzel";
            customer3.CustomerId = 8;
            customer3.CustomerHesapTürü = "Vadeli";
            customer3.CustomerHesaptakiPara = 1500;

            Customer customer4 = new Customer();
            customer4.CustomerAdi = "İrem";
            customer4.CustomerSoyadi = "Şirin";
            customer4.CustomerId = 10;
            customer4.CustomerHesapTürü = "Vadesiz";
            customer4.CustomerHesaptakiPara = 1200;



            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customer1);
            customerManager.CustomerList(customer1);
            customerManager.CustomerList(customer2);
            customerManager.CustomerList(customer3);
            customerManager.DeleteCustomer(customer4);


        }
    }
}
