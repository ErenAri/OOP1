using System;

namespace OOP_2
{
    class Program
    {
        private static object customer1;

        static void Main(string[] args)
        {
            İndividualCustomer customer1 = new İndividualCustomer() 
            {
                CustomerNumber = "12345",
                FirstName = "Eren",
                LastName = "Arı",
                TcNo = "12345678910",
            };

            CoorporateCustomer customer2 = new CoorporateCustomer() 
            {
                Id = 1,
                CustomerNumber = "123456",
                CompanyName = "Kodlama.İO",
                VergiNo = "12313",
            };

            Customer customer3 = new İndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
