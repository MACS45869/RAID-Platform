
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using RAIDPlateform.Data.Model.Client.Client_Application_Category;
using RAIDPlatform.Data.Model.Client.Client_Application_Category;
using RAIDPlatform.Data.Model.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Model.Client.Users;

namespace RAIDPlatform.Data.Repositories.Context
{
    public class ClientContext : BaseContext<ClientContext>
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) { }

        public DbSet<Client_Application_Category> client_Application_Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Client_Application_Category_Data_Map> client_Application_Category_Data_Maps { get; set; }


        
        
        }
    }
