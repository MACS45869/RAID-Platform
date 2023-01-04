
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Data.Models.Master.Application_Data_Map;
using RAIDPlatform.Data.Models.Master.Application_Feature_Map;
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;
using RAIDPlatform.Utilities;

namespace RAIDPlatform.Services.MasterService
{
    public class MasterService : IMasterService
    {
        private readonly IMasterRepository _masterRepository;

        public MasterService(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
        public async Task<Response<List<Feature_Permissions>>> GetAllFeaturePermissionAsync()
        {
            var query = await _masterRepository.GetAllFeaturePermissions();
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Feature_Permissions>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Feature_Permissions>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<Feature_Permissions>> GetFeaturePermissionByIdAsync(int id)
        {
            try
            {
                var response = await _masterRepository.GetFeaturePermissionById(id);
                return new Response<Feature_Permissions>()
                {
                    Success = response != null ? true : false,
                    Message = response != null ? $"Successfully fetched Feature Permission." : "Sorry, No Feature Permission found",
                    Data = response != null ? response : null

                };

            }
            catch (Exception ex)
            {
                return new Response<Feature_Permissions>()
                {
                    Success = false,
                    Message = $"Error occurred while Feature Permission responses. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<int>> AddFeaturePermissionAsync(Feature_Permissions feature_Permissions)
        {
            try
            {
                var query = await _masterRepository.AddFeaturePermission(feature_Permissions);

                if (query != 0)
                {

                    return new Response<int>()
                    {
                        Success = true,
                        Message = $"Feature Permission Added Successfully",
                        Data = query
                    };
                }
                else
                {
                    return new Response<int>()
                    {
                        Success = false,
                        Message = "Failed to add Feature Permission."
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<int>()
                {
                    Success = false,
                    Message = $"Failed to add Feature Permission. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<Feature_Permissions>> UpdateFeaturePermissionAsync(Feature_Permissions feature_Permissions, int Id)
        {
            var ua = await GetFeaturePermissionByIdAsync(Id);
            if (ua == null)
            {
                return new Response<Feature_Permissions>()
                {
                    Success = false,
                    Message = $"Sorry no Feature Permission found.",
                    Data = null
                };
            }
            else
            {
                try
                {
                    if (ua != null)
                    {
                        ua.Data.Feature_Permission_Name = feature_Permissions.Feature_Permission_Name;
                        ua.Data.Feature_Permission_Description = feature_Permissions.Feature_Permission_Description;
                        ua.Data.Feature_Permission_Key = feature_Permissions.Feature_Permission_Key;
                        ua.Data.Parent_ID = feature_Permissions.Parent_ID;
                        ua.Data.Is_Header = feature_Permissions.Is_Header;
                        ua.Data.Sequence_Number = feature_Permissions.Sequence_Number;
                        ua.Data.Updated_By_ID = feature_Permissions.Updated_By_ID;
                        ua.Data.Updated_By_Name = feature_Permissions.Updated_By_Name;
                        ua.Data.Updated_Date = DateTime.Now.Date;
                    }
                    //await _masterRepository.UpdateFeaturePermission(ua); // Useless code, not required (Remove this line)

                    // We will send the "ua" variable because it has the original data which has been modified in the above if statement body
                    // not the variable which is new coming from outside service
                    var response = await _masterRepository.UpdateFeaturePermission(ua.Data);

                    return new Response<Feature_Permissions>()
                    {
                        Success = response > 0 ? true : false,
                        Message = response > 0 ? $"Successfully Updated Feature Permission." : "",
                        Data = response > 0 ? ua.Data : null
                    };
                }
                catch (Exception ex)
                {
                    return new Response<Feature_Permissions>()
                    {
                        Success = false,
                        Message = $"Error occurred while updating Feature Permission. Reason: {ex.Message}",
                        Data = null
                    };
                }
            }
        }
        public async Task<Response<bool>> DeleteFeaturePermissionAsync(int id)
        {
            try
            {
                var query = await _masterRepository.DeleteFeaturePermission(id);
                if (query)
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Feature Permission successfully deleted",
                        Data = true
                    };
                }
                else
                {
                    return new Response<bool>()
                    {
                        Success = query,
                        Message = "Failed to delete Feature Permission",
                        Data = false
                    };
                }
            }
            catch (Exception ex)
            {
                return new Response<bool>()
                {
                    Success = false,
                    Message = $"Exception occurred while deleting Feature Permission. Reason: {ex.Message}"
                };
            }
        }
        public async Task<Response<List<Applications>>> GetAllApplicationsAsync()
        {
            var query = await _masterRepository.GetAllApplications();
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Applications>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Applications>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }
        public async Task<Response<Applications>> GetApplicationByIdAsync(int id)
        {
            try
            {
                var response = await _masterRepository.GetApplicationByID(id);
                return new Response<Applications>()
                {
                    Success = response != null ? true : false,
                    Message = response != null ? $"Successfully fetched Application." : "Sorry, No Application found",
                    Data = response != null ? response : null

                };

            }
            catch (Exception ex)
            {
                return new Response<Applications>()
                {
                    Success = false,
                    Message = $"Error occurred while Application responses. Reason: {ex.Message}",
                    Data = null
                };
            }
        }
        public async Task<Response<List<Application_Feature_Map>>> GetAllFeaturePermissionByApplicationIdAsync(int Id)
        {
            var query = await _masterRepository.GetAllFeaturePermissionByApplicationId(Id);
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Application_Feature_Map>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Application_Feature_Map>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }

        public async Task<Response<List<Applications>>> GetAllDataPermissionByApplicationIdAsync(int Id)
        {
            var query = await _masterRepository.GetAllDataPermissionsByApplicationId(Id);
            if (query == null || query.Count <= 0)
            {
                return new Response<List<Applications>>()
                {
                    Success = false,
                    Message = "No Data found"
                };
            }

            return new Response<List<Applications>>()
            {
                Success = true,
                Message = $"{query.Count} fetched successfully",
                Data = query
            };
        }

    }
}
