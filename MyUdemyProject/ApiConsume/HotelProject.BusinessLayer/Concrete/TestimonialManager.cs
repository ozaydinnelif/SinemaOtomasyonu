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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;
        
        public TestimonialManager(ITestimonialDal testimonialDal) 
        { 
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }


        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.Getlist();
        }
        public void TInsert(Room t)
        {
            _testimonialDal.Insert(t);
        }

        public void TInsert(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Room t)
        {
            _testimonialDal.Update(t);
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }

        List<Testimonial> IGenericService<Testimonial>.TGetList()
        {
            throw new NotImplementedException();
        }
    }
}
