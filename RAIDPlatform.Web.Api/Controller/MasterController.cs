using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Utilities;
using RAIDPlatform.Web.Api.DTO.ClientDTO;
using RAIDPlatform.Web.Api.DTO;
using RAIDPlatform.Services.MasterService;
using RAIDPlatform.Web.Api.DTO.MasterDTO;
using RAIDPlatform.Web.Api.DTO.RequestDtos;
using RAIDPlatform.Data.Models.Master.Feature_Permissions;
using RAIDPlatform.Web.Api.Minimal;

namespace RAIDPlatform.Web.Api.Controller
{

    public class MasterController : ControllerBase
    {
        private readonly IMasterService _masterService;
        private readonly IMapper _mapper;
        public MasterController(IMasterService masterService,IMapper mapper)
        {
            _masterService = masterService;
            _mapper = mapper;
        }
        private IActionResult CatchStatements(Exception exe, string msg)
        {

            if (exe.InnerException != null && exe.InnerException is DbUpdateException)
                return BadRequest(new Response<int>()
                {
                    Success = false,
                    Message = exe.InnerException.ToString(),
                    Error = new Error()
                    {
                        Code = ErrorCodes.DB_ERROR,
                        Cause = exe.Message + (exe.InnerException != null && !String.IsNullOrEmpty(exe.InnerException.Message) ? $"INNEX [{exe.InnerException.Message}]" : "")
                    }
                });
            return BadRequest(new Response<int>()
            {
                Success = false,
                Message = $"[{msg}] [{exe.Message}]",
                Error = new Error()
                {
                    Code = ErrorCodes.UNKNOWN_ERROR,
                    Cause = exe.Message
                }
            });
        }
        [HttpGet]
        [Route("api/master/featurepermission/all")]
        public async Task<IActionResult> GetAllFeaturePermission()
        {
            try
            {
                var query = await _masterService.GetAllFeaturePermissionAsync();
                List<Feature_Permission_Dto> _doc = _mapper.Map<List<Feature_Permission_Dto>>(query.Data);

                if (query.Success)
                {
                    return Ok(new Response<List<Feature_Permission_Dto>>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _doc
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Feature Permission fetching failed due to"));
            }
        }
        [HttpGet]
        [Route("api/master/featurepermission/{id}")]
        public async Task<IActionResult> GetFeaturePermissionByID([FromRoute] int id)
        {
            try
            {
                var query = await _masterService.GetFeaturePermissionByIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Feature_Permission_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Feature_Permission_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Feature Permission fetching failed due to "));
            }
        }

        [HttpPost]
        [Route("api/master/featurepermission/add")]
        public async Task<IActionResult> AddFeaturePermission([FromBody] AddFeaturePermissionDTO addFeaturePermissionDTO)
            {
            try
            {
                Feature_Permissions feature_Permission_Dto = _mapper.Map<Feature_Permissions>(addFeaturePermissionDTO);
                var query = await _masterService.AddFeaturePermissionAsync(feature_Permission_Dto);

                if (query.Success)
                {
                    return Ok(query);
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Feature Permission inserting failed due to "));
            }
        }

        [HttpPost]
        [Route("api/master/featurepermission/update/{Id}")]
        public async Task<IActionResult> UpdateFeaturePermission([FromBody] UpdateFeaturePermissionDTO updateFeaturePermissionDTO, [FromRoute] int Id)
            {
            try
            {
                Feature_Permissions feature_Permissions = _mapper.Map<Feature_Permissions>(updateFeaturePermissionDTO);
                var query = await _masterService.UpdateFeaturePermissionAsync(feature_Permissions, Id);

                if (query.Success)
                {
                    return Ok(new Response<Feature_Permission_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Feature_Permission_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Feature Permission Updating failed due to "));
            }
        }
        [HttpDelete]
        [Route("api/master/featurepermission/delete/{id}")]
        public async Task<IActionResult> DeleteFeaturePermissionById([FromRoute] int id)
        {
            try
            {
                var query = await _masterService.DeleteFeaturePermissionAsync(id);
                if (query.Success)
                {
                    return Ok(query);
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Exception occurred while deleting Feature Permission. Exception: "));
            }
        }
        [HttpGet]
        [Route("api/master/applicationfeaturepermission/byapplicationid/{id}")]
        public async Task<IActionResult> GetAllFeaturePermissionsByApplicationID([FromRoute] int id)
        {
            try
            {
                var query = await _masterService.GetAllFeaturePermissionByApplicationIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<List<Application_Feature_Map_Dto>>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<List<Application_Feature_Map_Dto>>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Feature Permissions By Application Id fetching failed due to "));
            }
        }
        [HttpGet]
        [Route("api/master/applicationdatapermission/byapplicationid/{id}")]
        public async Task<IActionResult> GetAllDataPermissionsByApplicationID([FromRoute] int id)
        {
            try
            {
                var query = await _masterService.GetAllDataPermissionByApplicationIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<List<MinimalApplicationDto>>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<List<MinimalApplicationDto>>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Data Permissions By Application Id fetching failed due to "));
            }
        }
        [HttpGet]
        [Route("api/master/applications/all")]
        public async Task<IActionResult> GetAllApplications()
        {
            try
            {
                var query = await _masterService.GetAllApplicationsAsync();
                List<Applications_Dto> _doc = _mapper.Map<List<Applications_Dto>>(query.Data);

                if (query.Success)
                {
                    return Ok(new Response<List<Applications_Dto>>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _doc
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Applications fetching failed due to"));
            }
        }
        [HttpGet]
        [Route("api/master/applications/{id}")]
        public async Task<IActionResult> GetApplicationByID([FromRoute] int id)
        {
            try
            {
                var query = await _masterService.GetApplicationByIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Applications_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Applications_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Application fetching failed due to "));
            }
        }
    }
}
