﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Logic_Layer.Entity
{
    public class AppDbContext : DbContext
    {
       

        public DbSet<User> User { get; set; }
    }
}