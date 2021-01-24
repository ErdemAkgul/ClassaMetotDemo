using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void CustomerAdd(Customer[] customers)
        {
            foreach (Customer custumer in customers)
            {
                Console.WriteLine(custumer.CustomerName + " " +custumer.CustomerSurname + " " + custumer.CustomerAge + " " + custumer.Id);
                Console.WriteLine("==========================================================");
            }

        }

        public void CustemerList (Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri adı:" + customer.CustomerName);
                Console.WriteLine("Müşteri Soyadı:" + customer.CustomerSurname);
                Console.WriteLine("Müşteri Yaşı:" + customer.CustomerAge);
                Console.WriteLine("Müşteri Id:" + customer.Id);
                Console.WriteLine("==========================================================");

            }
        }

        public void CustemerDelete(Customer[] custemers)
        {
            foreach (Customer customer in custemers)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + "Silindi");
            }
        }
            

    }
}
