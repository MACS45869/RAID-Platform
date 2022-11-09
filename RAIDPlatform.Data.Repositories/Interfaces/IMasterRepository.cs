using RAIDPlatform.Data.Model.Master.Applications;

namespace RAIDPlatform.Data.Repositories.Interfaces
{
    public interface IMasterRepository
    {
        Task<Applications> GetApplicationByID(int appId);
        Task<List<Applications>> GetAllApplications();
        Task<int> AddApplicationAsync(Applications app);
        Task UpdateApplication(int appId, Applications app);
        Task DeleteApplication(int appId);
    }
}
