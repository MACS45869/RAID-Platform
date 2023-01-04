using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Data.Models.Master.Applications;
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
        Task<Response<List<Applications>>> GetAllApplicationsAsync();
        Task<Response<Applications>> GetApplicationByIdAsync(int id);
        Task<Response<List<Application_Feature_Map>>> GetAllFeaturePermissionByApplicationIdAsync(int Id);
        Task<Response<List<Applications>>> GetAllDataPermissionByApplicationIdAsync(int Id);
    }
}
