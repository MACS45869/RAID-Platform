using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using RAIDPlatform.Data.Models.Client;
using RAIDPlatform.Data.Models.Client.Client_Application_Category;
using RAIDPlatform.Data.Models.Client.Clients;
using RAIDPlatform.Data.Models.Client.Users;
using RAIDPlatform.Data.Models.Master.Applications;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Services.ClientService;
using RAIDPlatform.Utilities;
using RAIDPlatform.Web.Api.DTO.ClientDTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using RAIDPlatform.Web.Api.DTO;
using RAIDPlatform.Web.Api.DTO.RequestDtos;

namespace RAIDPlatform.Web.Api.Controller
{

    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        public ClientsController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
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
        [Route("api/client/clientapplicationcategory/all")]
        public async Task<IActionResult> GetAllClientApplicationCategory()
        {
            try
            {
                var query = await _clientService.GetAllClientApplicationCategoryAsync();
                List<Client_Application_Category_Dto> _doc = _mapper.Map<List<Client_Application_Category_Dto>>(query.Data);

                if (query.Success)
                {
                    return Ok(new Response<List<Client_Application_Category_Dto>>()
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
                return (CatchStatements(ex, "Client Application Category fetching failed due to"));
            }
        }
        [HttpGet]
        [Route("api/client/clientapplicationcategory/{id}")]
        public async Task<IActionResult> GetClientApplicationCategoryByID([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.GetClientApplicationCategoryByIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Client_Application_Category_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Client_Application_Category_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Category fetching failed due to "));
            }
        }
      
        [HttpPost]
        [Route("api/client/clientapplicationcategory/add")]
        public async Task<IActionResult> AddClientApplicationCategory([FromBody] AddClientApplicationCategoryDTO addClientApplicationCategoryDTO)
        {
            try
            {
                Client_Application_Category client_Application_Category = _mapper.Map<Client_Application_Category>(addClientApplicationCategoryDTO);
                var query = await _clientService.AddClientApplicationCategoryAsync(client_Application_Category);

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
                return (CatchStatements(ex, "Client Application Category inserting failed due to "));
            }
        }

        [HttpPost]
        [Route("api/client/clientapplicationcategory/update")]
        public async Task<IActionResult> UpdateClientApplicationCategory([FromBody] UpdateClientApplicationCategoryDTO updateClientApplicationCategoryDTO)
        {
            try
            {
                Client_Application_Category client_Application_Category = _mapper.Map<Client_Application_Category>(updateClientApplicationCategoryDTO);
                var query = await _clientService.UpdateClientApplicationCategoryAsync(client_Application_Category, client_Application_Category.Id);

                if (query.Success)
                {
                    return Ok(new Response<Client_Application_Category_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Client_Application_Category_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Category Updating failed due to "));
            }
        }
        [HttpDelete]
        [Route("api/client/clientapplicationcategory/delete/{id}")]
        public async Task<IActionResult> DeleteClientApplicationCategoryById([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.DeleteClientApplicationCategoryAsync(id);
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
                return (CatchStatements(ex, "Exception occurred while deleting Client Application Category. Exception: "));
            }
        }

        [HttpGet]
        [Route("api/client/clientapplicationcategory/byclientid/{id}")]
        public async Task<IActionResult> GetClientApplicationCategoryByApplicationID([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.GetAllClientApplicationCategoryByClientIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Client_Application_Category_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Client_Application_Category_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Category By Client Id fetching failed due to "));
            }
        }
        [HttpGet]
        [Route("api/client/clientapplicationsecuritygroup/all")]
        public async Task<IActionResult> GetAllClientApplicationSecurityGroup()
        {
            try
            {
                var query = await _clientService.GetAllClientApplicationSecurityGroupAsync();
                List<Client_Application_Security_Group_Dto> _doc = _mapper.Map<List<Client_Application_Security_Group_Dto>>(query.Data);

                if (query.Success)
                {
                    //return Ok(new Response<List<Client_Application_Security_Group_Dto>>()
                    //{
                    //    Success = query.Success,
                    //    Message = query.Message,
                    //    Data = _doc
                    //});
                    return Ok(query);
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Security Group fetching failed due to"));
            }
        }
        [HttpGet]
        [Route("api/client/clientapplicationsecuritygroup/{id}")]
        public async Task<IActionResult> GetClientApplicationSecurityGroupByID([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.GetClientApplicationSecurityGroupByIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Client_Application_Security_Group_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Client_Application_Security_Group_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Security Group fetching failed due to "));
            }
        }
        [HttpPost]
        [Route("api/client/clientapplicationsecuritygroup/add")]
        public async Task<IActionResult> AddClientApplicationSecurityGroup([FromBody] AddClientApplicationSecurityGroupDTO addClientApplicationSecurityGroupDTO)
        {
            try
            {
                Client_Application_Security_Group client_Application_Security_Group = _mapper.Map<Client_Application_Security_Group>(addClientApplicationSecurityGroupDTO);
                var query = await _clientService.AddClientApplicationSecurityGroupAsync(client_Application_Security_Group);

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
                return (CatchStatements(ex, "Client Application Security Group inserting failed due to "));
            }
        }

        [HttpPost]
        [Route("api/client/clientapplicationsecuritygroup/update")]
        public async Task<IActionResult> UpdateClientApplicationSecurityGroup([FromBody] UpdateClientApplicationCategoryDTO updateClientApplicationCategoryDTO)
        {
            try
            {
                Client_Application_Security_Group client_Application_Security_Group = _mapper.Map<Client_Application_Security_Group>(updateClientApplicationCategoryDTO);
                var query = await _clientService.UpdateClientApplicationSecurityGroupAsync(client_Application_Security_Group, client_Application_Security_Group.Id);

                if (query.Success)
                {
                    return Ok(new Response<Client_Application_Security_Group_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Client_Application_Security_Group_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Security Group Updating failed due to "));
            }
        }
        [HttpDelete]
        [Route("api/client/clientapplicationsecuritygroup/delete/{id}")]
        public async Task<IActionResult> DeleteClientApplicationSecurityGroupById([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.DeleteClientApplicationSecurityGroupAsync(id);
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
                return (CatchStatements(ex, "Exception occurred while deleting Client Application Security Group. Exception: "));
            }
        }

        [HttpGet]
        [Route("api/client/clientapplicationsecuritygroup/byclientid/{id}")]
        public async Task<IActionResult> GetClientApplicationSecurityGroupByCientID([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.GetAllClientApplicationSecurityGroupByClientIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Client_Application_Security_Group_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Client_Application_Security_Group_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Client Application Security Group By Client Id fetching failed due to "));
            }
        }
        [HttpGet]
        [Route("api/client/users/all")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var query = await _clientService.GetAllUsersAsync();
                List<Users_Dto> _doc = _mapper.Map<List<Users_Dto>>(query.Data);

                if (query.Success)
                {
                    return Ok(new Response<List<Users_Dto>>()
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
                return (CatchStatements(ex, "Users fetching failed due to"));
            }
        }
        [HttpGet]
        [Route("api/client/users/{id}")]
        public async Task<IActionResult> GetUsersByID([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.GetUsersByIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Users_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Users_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Users fetching failed due to "));
            }
        }

        [HttpPost]
        [Route("api/client/users/add")]
        public async Task<IActionResult> AddUsers([FromBody] AddUsersDTO addUsersDTO)
        {
            try
            {
                Users users = _mapper.Map<Users>(addUsersDTO);
                var query = await _clientService.AddUserAsync(users);

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
                return (CatchStatements(ex, "Users inserting failed due to "));
            }
        }

        [HttpPost]
        [Route("api/client/users/update")]
        public async Task<IActionResult> UpdateUsers([FromBody] UpdateUsersDTO updateUsersDTO)
        {
            try
            {
                Users users = _mapper.Map<Users>(updateUsersDTO);
                var query = await _clientService.UpdateUsersAsync(users, users.Id);

                if (query.Success)
                {
                    return Ok(new Response<Users_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Users_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Users Updating failed due to "));
            }
        }
        [HttpDelete]
        [Route("api/client/users/delete/{id}")]
        public async Task<IActionResult> DeleteUsersById([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.DeleteUsersAsync(id);
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
                return (CatchStatements(ex, "Exception occurred while deleting Users. Exception: "));
            }
        }

        [HttpGet]
        [Route("api/client/users/byclientid/{id}")]
        public async Task<IActionResult> GetUsersByClientID([FromRoute] int id)
        {
            try
            {
                var query = await _clientService.GetAllUsersByClientIdAsync(id);

                if (query.Success)
                {
                    return Ok(new Response<Users_Dto>()
                    {
                        Success = query.Success,
                        Message = query.Message,
                        Data = _mapper.Map<Users_Dto>(query.Data)
                    });
                }
                else
                {
                    return BadRequest(query);
                }
            }
            catch (Exception ex)
            {
                return (CatchStatements(ex, "Users By Client Id fetching failed due to "));
            }
        }
    }
}
