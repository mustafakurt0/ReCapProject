using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rental;
        private ICarDal _carDal;

        public RentalManager(IRentalDal rental, ICarDal carDal)
        {
            _rental = rental;
            _carDal = carDal;
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rental.Get(r => r.CarId == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rental.GetAll());
        }

        public IResult Add(Rental rental)
        {
            Car car = _carDal.Get(r => r.CarId == rental.CarId);
            if (car.CarStatusId != 5)
            {
                return new ErrorResult("Araç Kullanımda");
            }

            _rental.Add(rental);
           return new SuccessResult();

        }

        public IResult Update(Rental rental)
        {
            _rental.Update(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rental.Delete(rental);
            return new SuccessResult();
        }
    }
}
