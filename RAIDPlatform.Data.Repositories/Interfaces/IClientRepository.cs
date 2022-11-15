using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.Users;

namespace RAIDPlatform.Data.Repositories.Interfaces
{
    public interface IClientRepository 
    {
        Task<List<Clients>> GetAllClient();
        Task<Clients> GetClientsByID(int clientId);
        Task<int> AddClient(Clients clients);
        Task UpdateClients(int clientId, Clients clients);
        Task DeleteClients(int clientId);
        Task<List<Client_Application_Category>> GetAllClientApplicationCategory();
        Task<Client_Application_Category> GetClientApplicationCategoryByID(int clientCategoryId);
        Task<int> AddClientApplicationCategory(Client_Application_Category client_Application_Category);
        Task UpdateClientApplicationCategory(int clientApplicationCategoryId, Client_Application_Category client_Application_Category);
        Task DeleteClientApplicationCategory(int clientApplicationCategoryId);
        Task<List<Client_Application_Security_Group>> GetAllClientApplicationSecurityGroup();
        Task DeleteClientApplicationSecurityGroup(int clientApplicationSecurityGroupId);
        Task UpdateClientApplicationSecurityGroup(int clientApplicationSecurityGroupId, Client_Application_Security_Group client_Application_Security_Group);
        Task<int> AddClientApplicationSecurityGroup(Client_Application_Security_Group client_Application_Security_Group);
        Task<Client_Application_Security_Group> GetClientApplicationSecurityGroupById(int clientApplicationSecurityGroupId);
        Task<List<Users>> GetAllUsers();
        Task DeleteUsers(int userId);
        Task UpdateUsers(int userId, Users users);
        Task<int> AddUser(Users users);
        Task<Users> GetUsersByID(int userId);

    }
}
