﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carStatus in context.CarStates on car.CarStatusId equals carStatus.Id
                    select new CarDetailDto
                    {
                        CarName = car.CarName, BrandName = brand.BrandName, ColorName = color.ColorName,
                        CarStatus = carStatus.Status,
                        DailyPrice = car.DailyPrice
                    };
                return result.ToList();
            }
        }
    }
}
