﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(int carId)
        {
           _carDal.Delete(carId);
        }
    }
}