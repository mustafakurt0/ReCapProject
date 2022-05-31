using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class CarStatus : IEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
