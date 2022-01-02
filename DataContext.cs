using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite_CRUD
{
    public class DataContext : DbContext
    {

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlite( "Data Source = UserData2.db" );
        }

        public DbSet<User> Users { get; set; }

    }
}
