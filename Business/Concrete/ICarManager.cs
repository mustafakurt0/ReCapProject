using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ICarManager : ICarService
    {
        private ICarDal _carDal;

        public ICarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public Car Get(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
            Console.WriteLine("CarAdded");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(int carId)
        {
            //
        }
    }
}
