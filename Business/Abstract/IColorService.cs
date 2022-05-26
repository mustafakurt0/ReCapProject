using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        Color Get(int id);
        List<Color> GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(int colorId);
    }
}
