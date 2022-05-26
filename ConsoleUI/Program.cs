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
            //InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();
            EfCarDal efCarDal = new EfCarDal();
            ICarManager carManager = new ICarManager(efCarDal);

            EfBrandDal brandDal = new EfBrandDal();
            IBrandManager brandManager = new IBrandManager(brandDal);

            EfColorDal colorDal = new EfColorDal();
            IColorManager colorManager = new IColorManager(colorDal);

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }
    }
}
