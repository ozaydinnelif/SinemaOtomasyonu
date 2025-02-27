﻿using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-F80COFD;initial catalog=ApiDb;Integrated Security=true;Trust Server Certificate=True");
        }
        public DbSet<Room>Rooms{ get; set; }
        public DbSet<Service>Services{ get; set; }
        public DbSet<Staff>Staffs{ get; set; }
        public DbSet<Subscribe>Subscribes{ get; set; }
        public DbSet<Testimonial>Testimonials{ get; set; }
    }
}
