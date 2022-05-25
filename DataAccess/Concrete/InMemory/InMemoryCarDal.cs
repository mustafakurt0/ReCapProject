using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {CarId = 1, BrandId = 1 , ColorId = 2 ,DailyPrice = 200, ModelYear = 2015, Description = "BMW X5 Beyaz"},
                new Car {CarId = 2, BrandId = 1 , ColorId = 1 ,DailyPrice = 180, ModelYear = 2013, Description = "BMW X3 Siyah"},
                new Car {CarId = 3, BrandId = 2 , ColorId = 2 ,DailyPrice = 300, ModelYear = 2019, Description = "Mercedes C180 Beyaz"},
                new Car {CarId = 4, BrandId = 3 , ColorId = 1 ,DailyPrice = 150, ModelYear = 2012, Description = "VW Passat Siyah"},
                new Car {CarId = 5, BrandId = 3 , ColorId = 3 ,DailyPrice = 200, ModelYear = 2018, Description = "VW Arteon Sarı"},
                new Car {CarId = 6, BrandId = 3 , ColorId = 4 ,DailyPrice = 200, ModelYear = 2018, Description = "VW Arteon Kırmızı"},
                new Car {CarId = 7, BrandId = 4 , ColorId = 4 ,DailyPrice = 350, ModelYear = 2019, Description = "Porsche Taycan Kırmızı"},
            };
        }
        public Car GetById(int id)
        {
            Car car = _cars.FirstOrDefault(c => c.CarId == id);
            return car;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine("Car Added");
        }

        public void Update(Car car)
        {
            Car carToUpdated = _cars.Find(c => c.CarId == car.CarId);
            carToUpdated.BrandId = car.BrandId;
            carToUpdated.ModelYear = car.ModelYear;
            carToUpdated.Description = car.Description;
            carToUpdated.ColorId = car.ColorId;
            carToUpdated.DailyPrice = car.DailyPrice;
            Console.WriteLine("Car Updated");
        }

        public void Delete(int carId)
        {
            Car carToDeleted = _cars.FirstOrDefault(c => c.CarId == carId);
            _cars.Remove(carToDeleted);
            Console.WriteLine("Car Deleted");
        }
    }
}
