﻿using HotelProject.BusinessLayer.Abstract;
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
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal) 
        {
           _staffDal = staffDal;
        }
        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }


        public Staff TGetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public List<Room> TGetList()
        {
            return _staffDal.GetList();
        }

        public object TGetList(object values)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }

        List<Staff> IGenericService<Staff>.TGetList()
        {
            throw new NotImplementedException();
        }

        object IStaffService.TGetList()
        {
            throw new NotImplementedException();
        }
    }
}
