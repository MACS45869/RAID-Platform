using RAIDPlatform.Data.Model.Client.Users;

namespace RAIDPlatform.Data.Repositories.Interfaces
{
    public interface IClientRepository 
    {
        Task<List<Users>> GetAllUsers();
        Task<Users> GetUsersById(int userId);
        Task<int> AddUsers(Users users);
        Task<int> UpdateUser(Users users);
        Task<bool> DeleteUsers(int id);

    }
}
