using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;

namespace RAIDPlatform.Data.Repositories.Interfaces
{
    public interface IMasterRepository
    {
        Task<Applications> GetApplicationByID(int appId);
        Task<List<Applications>> GetAllApplications();
        Task<int> AddApplicationAsync(Applications app);
        Task UpdateApplication(int appId, Applications app);
        Task DeleteApplication(int appId);
        Task<List<Feature_Permissions>> GetAllFeaturePermissions();
        Task<Feature_Permissions> GetFeaturePermissionById(int featurePermissionId);
        Task<int> AddFeaturePermission(Feature_Permissions feature_Permissions);
        Task<int> UpdateFeaturePermission(Feature_Permissions feature_Permissions);
        Task<bool> DeleteFeaturePermission(int featurePermissionId);
    }
}
