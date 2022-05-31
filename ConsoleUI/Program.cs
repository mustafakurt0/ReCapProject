using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }

        private static void Test2()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer();
            customer.CompanyName = "Kurtoğulları";
            customer.UserId = 1;
            var result = customerManager.Add(customer);
            Console.WriteLine(result.Success);
        }

        private static void Test()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User
            {
                FirstName = "Mustafa",
                LastName = "Kurt",
                Email = "mustafa@gmail.com",
                Password = "123456"
            };
            var result = userManager.Add(user);
            Console.WriteLine(result.Success);
        }
    }
}
