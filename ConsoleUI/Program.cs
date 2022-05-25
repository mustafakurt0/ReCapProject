using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            ICarManager carManager = new ICarManager(inMemoryCarDal);

            //TEST

            while (true)
            {
                Console.WriteLine("\nİşlem Giriniz");
                string input = Console.ReadLine();
                if (input == "get")
                {
                    Console.WriteLine("Car Id giriniz : ");
                    string carIdInput = Console.ReadLine(); 
                    int carId = int.Parse(carIdInput);
                    Car car = carManager.GetById(carId);
                    if (car == null)
                    {
                        Console.WriteLine("Böyle bir araç bulunamadı ");
                    }
                    else
                    {
                        Console.WriteLine(car.Description);
                    }

                    
                }else if (input == "getall")
                {
                    foreach (Car car in carManager.GetAll())
                    {
                        Console.WriteLine(car.Description);
                    }
                }else if (input == "update")
                {
                    Console.WriteLine("Car Id giriniz : ");
                    string carIdInput = Console.ReadLine();
                    int carId = int.Parse(carIdInput);

                }
                else if (input == "delete")
                {
                    Console.WriteLine("Car Id giriniz : ");
                    string carIdInput = Console.ReadLine();
                    int carId = int.Parse(carIdInput);
                    carManager.Delete(carId);

                }
                else
                {
                    Console.WriteLine("**************************");
                }
            }
        }
    }
}
