using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AspNetActionFilter.Models;
namespace AspNetActionFilter.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Log> Logs {get;set;}
        public DbSet<User> User { get; set; }

    
    public DatabaseContext()
    {
        Database.SetInitializer(new MyInitializer());
    }
    }
}