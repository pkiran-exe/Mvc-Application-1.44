﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeSec4.Data
{
    public class SchoolDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SchoolDbContext() : base("name=SchoolDbContext")
        {
        }

        public System.Data.Entity.DbSet<PracticeSec4.Models.Classes> Classes { get; set; }

        public System.Data.Entity.DbSet<PracticeSec4.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<PracticeSec4.Models.Subject> Subjects { get; set; }
    }
}
