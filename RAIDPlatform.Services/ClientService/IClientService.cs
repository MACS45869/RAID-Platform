using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Utilities;

namespace RAIDPlatform.Services.ClientService
{
    public interface IClientService
    {
        Task<Response<List<Client_Application_Category>>> GetAllClientApplicationCategoryAsync();
        Task<Response<Client_Application_Category>> GetClientApplicationCategoryByIdAsync(int id);
        Task<Response<Client_Application_Category>> UpdateClientApplicationCategoryAsync(Client_Application_Category client_Application_Category, int Id);
        Task<Response<int>> AddClientApplicationCategoryAsync(Client_Application_Category client_Application_Category);
        Task<Response<bool>> DeleteClientApplicationCategoryAsync(int id);
        Task<Response<List<Client_Application_Category>>> GetAllClientApplicationCategoryByClientIdAsync(int Id);
        Task<Response<List<Client_Application_Security_Group>>> GetAllClientApplicationSecurityGroupAsync();
        Task<Response<List<Client_Application_Security_Group>>> GetAllClientApplicationSecurityGroupByClientIdAsync(int Id);
        Task<Response<Client_Application_Security_Group>> GetClientApplicationSecurityGroupByIdAsync(int id);
        Task<Response<int>> AddClientApplicationSecurityGroupAsync(Client_Application_Security_Group client_Application_Security_Group);
        Task<Response<Client_Application_Security_Group>> UpdateClientApplicationSecurityGroupAsync(Client_Application_Security_Group client_Application_Security_Group, int Id);
        Task<Response<bool>> DeleteClientApplicationSecurityGroupAsync(int id);
        Task<Response<Users>> UpdateUsersAsync(Users users, int Id);
        Task<Response<bool>> DeleteUsersAsync(int id);
        Task<Response<int>> AddUserAsync(Users users);
        Task<Response<Users>> GetUsersByIdAsync(int id);
        Task<Response<List<Users>>> GetAllUsersByClientIdAsync(int Id);
        Task<Response<List<Users>>> GetAllUsersAsync();
    }
}
