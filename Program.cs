using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Müşteri Listesi");

            Customer customer1 = new Customer();
            customer1.CustomerName = "Erdem";
            customer1.CustomerSurname = "Akgül";
            customer1.Id = 1;
            customer1.CustomerAge = 18;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Kıraç";
            customer2.CustomerSurname = "Kara";
            customer2.Id = 2;
            customer2.CustomerAge = 13;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Emirhan";
            customer3.CustomerSurname = "Yıldız";
            customer3.Id = 3;
            customer3.CustomerAge = 20;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.CustomerAdd(customers);
            customerManager.CustemerList(customers);
            customerManager.CustemerDelete(customers);






        }
    }
}
