using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Utilities;

namespace RAIDPlatform.Services.MasterService
{
    public interface IMasterService
    {
        Task<Response<List<Feature_Permissions>>> GetAllFeaturePermissionAsync();
        Task<Response<Feature_Permissions>> GetFeaturePermissionByIdAsync(int id);
        Task<Response<int>> AddFeaturePermissionAsync(Feature_Permissions feature_Permissions);
        Task<Response<Feature_Permissions>> UpdateFeaturePermissionAsync(Feature_Permissions feature_Permissions, int Id);
        Task<Response<bool>> DeleteFeaturePermissionAsync(int id);
    }
}
