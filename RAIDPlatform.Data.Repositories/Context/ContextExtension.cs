using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Map;
using RAIDPlatform.Data.Models.Client.Client_Application_Category_Data_Values;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Category_Map;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Feature_Map;
using RAIDPlatform.Data.Models.Client.Client_Data;
using RAIDPlatform.Data.Models.Client.Client_Features;
using RAIDPlatform.Data.Models.Client.Client_Module_Map;
using RAIDPlatform.Data.Models.Client.Client_Navigation_Feature_Map;
using RAIDPlatform.Data.Models.Client.Client_Navigations;
using RAIDPlatform.Data.Models.Client.Client_Parameter_Values;
using RAIDPlatform.Data.Models.Client.Client_Parameters;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.User_Category_Map;
using RAIDPlatform.Data.Models.Client.User_Security_Group_Map;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Master.Parameter_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Data.Models.Master.Application_Module_Map;
using RAIDPlatform.Data.Models.Master.Application_Navigation_Map;
using RAIDPlatform.Data.Models.Master.Application_Parameter_Map;
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Data_Permissions;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Data.Models.Master.Modules;
using RAIDPlatform.Data.Models.Master.Navigation_Feature_Map;
using RAIDPlatform.Data.Models.Master.Navigations;
using RAIDPlatform.Data.Models.Master;

namespace RAIDPlatform.Data.Repositories.Context
{
    public static class ContextExtension
    {

        public static void ConstructDatabaseModel(this ModelBuilder modelBuilder, IConfiguration configuration)
        {
            modelBuilder.Entity<Client_Application_Category>().ToTable("Client_Application_Category");
            modelBuilder.Entity<Parameter_Values>().ToTable("Parameter_Values");
            modelBuilder.Entity<Users>().ToTable("Users");



            modelBuilder.Entity<Client_Application_Category_Data_Map>().ToTable("Client_Application_Category_Data_Map");

            modelBuilder.Entity<Client_Application_Category_Data_Values>().ToTable("Client_Application_Category_Data_Values");

            modelBuilder.Entity<Client_Application_Security_Group>().ToTable("Client_Application_Security_Group");

            modelBuilder.Entity<Client_Application_Security_Group_Category_Map>().ToTable("Client_Application_Security_Group_Category_Map");

            modelBuilder.Entity<Client_Application_Security_Group_Feature_Map>().ToTable("Client_Application_Security_Group_Feature_Map");

            modelBuilder.Entity<Client_Data>().ToTable("Client_Data");

            modelBuilder.Entity<Client_Features>().ToTable("Client_Features");

            modelBuilder.Entity<Client_Module_Map>().ToTable("Client_Module_Map");

            modelBuilder.Entity<Client_Navigation_Feature_Map>().ToTable("Client_Navigation_Feature_Map");

            modelBuilder.Entity<Client_Navigations>().ToTable("Client_Navigations");

            modelBuilder.Entity<Client_Parameter_Values>().ToTable("Client_Parameter_Values");

            modelBuilder.Entity<Client_Parameters>().ToTable("Client_Parameters");

            modelBuilder.Entity<Clients>().ToTable("Clients");

            modelBuilder.Entity<User_Category_Map>().ToTable("User_Category_Map");

            modelBuilder.Entity<User_Security_Group_Map>().ToTable("User_Security_Group_Map");

            modelBuilder.Entity<Application_Data_Map>().ToTable("Application_Data_Map");
            modelBuilder.Entity<Application_Feature_Map>().ToTable("Application_Feature_Map");
            modelBuilder.Entity<Application_Module_Map>().ToTable("Application_Module_Map");
            modelBuilder.Entity<Application_Navigation_Map>().ToTable("Application_Navigation_Map");
            modelBuilder.Entity<Application_Parameter_Map>().ToTable("Application_Parameter_Map");
            modelBuilder.Entity<Applications>().ToTable("Applications");
            modelBuilder.Entity<Data_Permissions>().ToTable("Data_Permissions");
            modelBuilder.Entity<Feature_Permissions>().ToTable("Feature_Permissions");
            modelBuilder.Entity<Modules>().ToTable("Modules");
            modelBuilder.Entity<Navigation_Feature_Map>().ToTable("Navigation_Feature_Map");
            modelBuilder.Entity<Navigations>().ToTable("Navigations");
            modelBuilder.Entity<Parameter_Values>().ToTable("Parameter_Values");
            modelBuilder.Entity<Parameters>().ToTable("Parameters");
        }
    }
}
