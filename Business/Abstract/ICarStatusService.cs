using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarStatusService 
    {
        IDataResult<CarStatus> Get(int id);
        IDataResult<List<CarStatus>> GetAll();
        IResult Add(CarStatus carStatus);
        IResult Update(CarStatus carStatus);
        IResult Delete(CarStatus carStatus);
        
    }
}
