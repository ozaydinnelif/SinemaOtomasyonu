using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IServicesDal : IGenericDal<Service>

    {
        void Delete(Room t);
        void Insert(Room t);
        void Update(Room t);
    }
}
