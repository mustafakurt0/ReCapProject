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
    public class IColorManager  : IColorService
    {
        private IColorDal _colorDal;

        public IColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color Get(int id)
        {
            return _colorDal.Get(c => c.ColorId == id);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Color Added");
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Color Added");
        }

        public void Delete(int colorId)
        {
            //_colorDal.Delete(Color color);
            //Console.WriteLine("Brand Deleted");
        }
    }
}
