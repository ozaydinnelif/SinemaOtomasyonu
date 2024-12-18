using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IStaffDal : IGenericDal<Staff>
    {
        void Delete(Room t);
        List<Room> GetList();
        void Insert(Room t);
        void Update(Room t);
        void Update(Staff t);
    }
}
