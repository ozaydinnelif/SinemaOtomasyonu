using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal:GenericRepository<Staff>,IStaffDal
    {
        public EfStaffDal(Context context):base(context)
        {
            
        }

        public void Delete(Room t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Room t)
        {
            throw new NotImplementedException();
        }

        public void Update(Room t)
        {
            throw new NotImplementedException();
        }

        List<Room> IStaffDal.GetList()
        {
            throw new NotImplementedException();
        }
    }
}
