using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Client_Application_Security_Group_Category_Map;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.User_Security_Group_Map;
using RAIDPlatform.Data.Models.Client.Users;

namespace RAIDPlatform.Data.Repositories.Interfaces
{
    public interface IClientRepository 
    {
        Task<List<Clients>> GetAllClient();
        Task<Clients> GetClientsByID(int clientId);
        Task<int> AddClient(Clients clients);
        Task<int> UpdateClients(Clients clients);
        Task<bool> DeleteClients(int clientId);
        Task<List<Client_Application_Category>> GetAllClientApplicationCategory();
        Task<Client_Application_Category> GetClientApplicationCategoryById(int clientCategoryId);
        Task<int> AddClientApplicationCategory(Client_Application_Category client_Application_Category);
        Task<int> UpdateClientApplicationCategory(Client_Application_Category client_Application_Category);
        Task<bool> DeleteClientApplicationCategory(int clientApplicationCategoryId);
        Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroup();
        Task<bool> DeleteClientApplicationSecurityGroup(int clientApplicationSecurityGroupId);
        Task<int> UpdateClientApplicationSecurityGroup(Client_Application_Security_Group client_Application_Security_Group);
        Task<int> AddClientApplicationSecurityGroup(Client_Application_Security_Group client_Application_Security_Group);
        Task<Client_Application_Security_Group> GetClientApplicationSecurityGroupById(int clientApplicationSecurityGroupId);
        Task<List<Users>> GetAllUsers();
        Task<bool> DeleteUsers(int userId);
        Task<int> UpdateUsers(Users users);
        Task<int> AddUser(Users users);
        Task<Users> GetUsersByID(int userId);
        Task<List<Client_Application_Category>> GetAllClientApplicationCategoryByApplicationId(int appID);
        Task<List<Client_Application_Category>> GetAllClientApplicationCategoryByClientId(int clientID);
        Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroupByClientId(int clientID);
        Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroupByApplicationId(int appID);
        Task<List<Users>> GetAllUserByClientId(int clientID);
        Task<List<Users>> GetAllUsersByApplicationId(int appID);
        Task<List<User_Security_Group_Map>> AddUserSecurityGroupMap(List<User_Security_Group_Map> user_Security_Group_Maps);
        Task<List<Client_Application_Security_Group_Category_Map>> AddClientApplicationSecurityGroupCategoryMap(List<Client_Application_Security_Group_Category_Map> client_Application_Security_Group_Category_Map);
       
    }
}
