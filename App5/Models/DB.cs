using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace App5.Models
{
    public class DB:DbContext
    {
        public DbSet<Student> Student { get; set; }
    }
}