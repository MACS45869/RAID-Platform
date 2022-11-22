using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Utilities;

namespace RAIDPlatform.Services.ClientService
{
    public interface IClientService
    {
        Task<Response<List<Client_Application_Category>>> GetAllApplicationCategory();
        Task<Response<Client_Application_Category>> GetClientApplicationCategoryByIdAsync(int id);
    }
}
