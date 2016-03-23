using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using lab1.Models;

namespace lab1.Context
{
    public class CarContext : DbContext
    {
        public CarContext() : base("DefaultConnection") { }
        public DbSet<Car> Cars { get; set; }
        
    }
    
}