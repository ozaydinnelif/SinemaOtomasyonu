using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public class IRoomService : IGenericService<Room>
    {
        public void TDelete(Room t)
        {
            throw new NotImplementedException();
        }

        public Room TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Room> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Room t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Room t)
        {
            throw new NotImplementedException();
        }
    }
}
