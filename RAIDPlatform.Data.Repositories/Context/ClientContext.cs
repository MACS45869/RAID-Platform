
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Model.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Model.Client.Users;
using RAIDPlatform.Data.Model.Client.Client_Application_Category;
using RAIDPlatform.Data.Repositories.Base;

namespace RAIDPlatform.Data.Repositories.Context
{
    public class ClientContext : BaseDbContext<ClientContext>
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) { }

        public DbSet<Client_Application_Category> client_Application_Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Client_Application_Category_Data_Map> client_Application_Category_Data_Maps { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_Application_Category>().ToTable("Client_Application_Category");
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Client_Application_Category_Data_Map>().ToTable("Client_Application_Category_Data_Map");

            base.OnModelCreating(modelBuilder);
        }

    }
    }
