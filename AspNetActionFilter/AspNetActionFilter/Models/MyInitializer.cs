using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetActionFilter.Models
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            User user = new User()
            {
                Name="system",
                SurName="byHuseyin",
                Password="123",
                UserName="user"
            };
            context.User.Add(user);
            context.SaveChanges();
        }
    }
}