using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class IBrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public IBrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public Brand Get(int id)
        {
            return _brandDal.Get(b => b.BrandId == id);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
            Console.WriteLine("Brand Added");
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void Delete(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
