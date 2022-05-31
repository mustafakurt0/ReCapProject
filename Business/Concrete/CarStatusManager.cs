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
    public class CarStatusManager : ICarStatusService
    {
        private ICarStatusDal _carStatusDal;

        public CarStatusManager(ICarStatusDal carStatusDal)
        {
            _carStatusDal = carStatusDal;
        }

        public IDataResult<CarStatus> Get(int id)
        {
            return new SuccessDataResult<CarStatus>(_carStatusDal.Get(p => p.Id == id));
        }

        public IDataResult<List<CarStatus>> GetAll()
        {
            return new SuccessDataResult<List<CarStatus>>(_carStatusDal.GetAll());
        }

        public IResult Add(CarStatus carStatus)
        {
            _carStatusDal.Add(carStatus);
            return new SuccessResult();
        }

        public IResult Update(CarStatus carStatus)
        {
            _carStatusDal.Update(carStatus);
            return new SuccessResult();
        }

        public IResult Delete(CarStatus carStatus)
        {
            _carStatusDal.Delete(carStatus);
            return new SuccessResult();
        }
    }
}
