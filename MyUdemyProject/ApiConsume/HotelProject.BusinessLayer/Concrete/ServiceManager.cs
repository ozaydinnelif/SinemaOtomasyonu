using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal servicesDal;
        private IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Room t)
        {
            _servicesDal.Delete(t);
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TGetById(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public Service TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetRooms;
        }
        public void TInsert(Room t)
        {
            _servicesDal.Insert(t);
        }

        public void TInsert(Service t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Room t)
        {
            _servicesDal.Update(t);
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }

        List<Service> IGenericService<Service>.TGetList()
        {
            throw new NotImplementedException();
        }
    }
}
