using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext: DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public ApplicationDBContext(DbContextOptions dbContextOptions)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
          :base(dbContextOptions)
          // this base passes our dbContextOptions the ORM's inherited DbContext
        {
          
        }
        // database manipulation-the db itself
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Comment> Comments{ get; set; }
    }
}