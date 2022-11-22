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
using RAIDPlatform.Web.Api.Pages;

namespace RAIDPlatform.Web.Api.Controller
{

    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository clientRepository;
        public ClientsController(IClientRepository _clientRepo)
        {
            this.clientRepository = _clientRepo;
        }
        //For Services:
        //private readonly IClientService _clientService;
        //private readonly IMapper _mapper;
        //public ClientsController(IClientService clientService, IMapper mapper)
        //{
        //    _clientService = clientService;
        //    _mapper = mapper;
        //}

        //[HttpGet]
        //[Route("Client-Application-Category-all")]
        //public async Task<IActionResult> GetAllClientApplicationCategory()
        //{
        //    try
        //    {
        //        var query = await _clientService.GetAllApplicationCategory();
        //        List<Client_Application_Category_Dto> _doc = _mapper.Map<List<Client_Application_Category_Dto>>(query.Data);

        //        if (query.Success)
        //        {
        //            return Ok(new Response<List<Client_Application_Category_Dto>>()
        //            {
        //                Success = query.Success,
        //                Message = query.Message,
        //                Data = _doc
        //            });
        //        }
        //        else
        //        {
        //            return BadRequest(query);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (CatchStatements(ex, "Application Category fetching failed due to"));
        //    }
        //}
        //[HttpGet]
        //[Route("Client-Application-Category/getById/{id}")]
        //public async Task<IActionResult> GetClientApplicationCategoryByID([FromRoute] int id)
        //{
        //    try
        //    {
        //        var query = await _clientService.GetClientApplicationCategoryByIdAsync(id);

        //        if (query.Success)
        //        {
        //            return Ok(new Response<Client_Application_Category_Dto>()
        //            {
        //                Success = query.Success,
        //                Message = query.Message,
        //                Data = _mapper.Map<Client_Application_Category_Dto>(query.Data)
        //            });
        //        }
        //        else
        //        {
        //            return BadRequest(query);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (CatchStatements(ex, "Application Category fetching failed due to "));
        //    }
        //}
        //private IActionResult CatchStatements(Exception exe, string msg)
        //{

        //    if (exe.InnerException != null && exe.InnerException is DbUpdateException)
        //        return BadRequest(new Response<int>()
        //        {
        //            Success = false,
        //            Message = exe.InnerException.ToString(),
        //            Error = new Error()
        //            {
        //                Code = ErrorCodes.DB_ERROR,
        //                Cause = exe.Message + (exe.InnerException != null && !String.IsNullOrEmpty(exe.InnerException.Message) ? $"INNEX [{exe.InnerException.Message}]" : "")
        //            }
        //        });
        //    return BadRequest(new Response<int>()
        //    {
        //        Success = false,
        //        Message = $"[{msg}] [{exe.Message}]",
        //        Error = new Error()
        //        {
        //            Code = ErrorCodes.UNKNOWN_ERROR,
        //            Cause = exe.Message
        //        }
        //    });
        //}
    
      

        [HttpGet("client-all")]
        public async Task<IActionResult> GetAllClients()
        {
            var query = await clientRepository.GetAllClient();
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpGet("Clients/getById/{id}")]
        public async Task<IActionResult> GetClientsByID([FromRoute] int id)
        {

            var clients = await this.clientRepository.GetClientsByID(id);
            if (clients == null)
            {
                return NotFound();
            }
            return Ok(clients);
        }

        [HttpPost("add-clients")]
        public async Task<IActionResult> AddClients([FromBody] Clients clients)
        {
            var query = await clientRepository.AddClient(clients);
            if (query > 0)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpPost("Client/update/{id}")]
        public async Task<IActionResult> UpdateClients([FromBody] Clients clients, [FromRoute] int id)
        {
            await this.clientRepository.UpdateClients(id, clients);
            return Ok(clients.Client_ID);
        }

        [HttpDelete("Client/delete/{id}")]
        public async Task<IActionResult> DeleteClient(Clients clients,[FromRoute] int id)
        {
            await this.clientRepository.DeleteClients(id);
            return Ok(clients.Client_Name);
        }
        
        [HttpGet("Client-Application-Category-all")]
        public async Task<IActionResult> GetAllClientApplicationCategory()
        {
            var query = await clientRepository.GetAllClientApplicationCategory();
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        [HttpGet("Client-Application-Category-all/application/{id}")]
        public async Task<IActionResult> GetAllClientApplicationCategoryByApplication([FromRoute] int id)
        {
            var query = await clientRepository.GetAllClientApplicationCategoryByApplication(id);
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpGet("Client-Application-Category-all/client/{id}")]
        public async Task<IActionResult> GetAllClientApplicationCategoryByClient([FromRoute]int id)
        {
            var query = await clientRepository.GetAllClientApplicationCategoryByClient(id);
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        [HttpGet("Client-Application-Category/getById/{id}")]
        public async Task<IActionResult> GetClientApplicationCategoryByID([FromRoute] int id)
        {

            var cag = await this.clientRepository.GetClientApplicationCategoryByID(id);
            if (cag == null)
            {
                return NotFound();
            }
            return Ok(cag);
        }

        [HttpPost("Client-Application-Category/add")]
        public async Task<IActionResult> AddClientApplicationCategory([FromBody] Client_Application_Category client_Application_Category)
        {
            var query = await clientRepository.AddClientApplicationCategory(client_Application_Category);
            if (query > 0)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpPost("Client-Application-Category/update/{id}")]
        public async Task<IActionResult> UpdateClientApplicationCategory([FromBody] Client_Application_Category client_Application_Category, [FromRoute] int id)
        {
            await this.clientRepository.UpdateClientApplicationCategory(id, client_Application_Category);
            return Ok(client_Application_Category.Client_Application_Category_ID);
        }

        [HttpDelete("Client-Application-Category/delete/{id}")]
        public async Task<IActionResult> DeleteClientApplicationCategory(Client_Application_Category client_Application_Category, [FromRoute] int id)
        {
            await this.clientRepository.DeleteClientApplicationCategory(id);
            return Ok(client_Application_Category.Client_Application_Category_Name);
        }
        
        [HttpGet("Client-Application-Security-Group-all")]
        public async Task<IActionResult> GetAllClientApplicationSecurityGroup()
        {
            var query = await clientRepository.GetAllClientApplicationSecurityGroup();
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        [HttpGet("Client-Application-Security-Group-all/ByClient/{id}")]
        public async Task<IActionResult> GetAllClientApplicationSecurityGroupByClient(int id)
        {
            var query = await clientRepository.GetAllClientApplicationSecurityGroupByClient(id);
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        [HttpGet("Client-Application-Security-Group/getById/{id}")]
        public async Task<IActionResult> GetClientApplicationSecurityGroupByID([FromRoute] int id)
        {

            var cag = await this.clientRepository.GetClientApplicationSecurityGroupById(id);
            if (cag == null)
            {
                return NotFound();
            }
            return Ok(cag);
        }

        [HttpPost("Client-Application-Security-Group/add")]
        public async Task<IActionResult> AddClientApplicationSecurityGroup([FromBody] Client_Application_Security_Group client_Application_Security_Group)
        {
            var query = await clientRepository.AddClientApplicationSecurityGroup(client_Application_Security_Group);
            if (query > 0)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpPost("Client-Application-Security-Group/update/{id}")]
        public async Task<IActionResult> UpdateClientApplicationSecurityGroup([FromBody] Client_Application_Security_Group client_Application_Security_Group, [FromRoute] int id)
        {
            await this.clientRepository.UpdateClientApplicationSecurityGroup(id, client_Application_Security_Group);
            return Ok(client_Application_Security_Group.Client_Application_Security_Group_ID);
        }

        [HttpDelete("Client-Application-Security-Group/delete/{id}")]
        public async Task<IActionResult> DeleteClientApplicationSecurityGroup(Client_Application_Security_Group client_Application_Security_Group, [FromRoute] int id)
        {
            await this.clientRepository.DeleteClientApplicationSecurityGroup(id);
            return Ok(client_Application_Security_Group.Client_Application_Security_Group_Name);
        }
        
        [HttpGet("User-all")]
        public async Task<IActionResult> GetAllUser()
        {
            var query = await clientRepository.GetAllUsers();
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        [HttpGet("User/all/ByClient/{id}")]
        public async Task<IActionResult> GetAllUserByClient(int id)
        {
            var query = await clientRepository.GetAllUserByClient(id);
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        [HttpGet("User/getById/{id}")]
        public async Task<IActionResult> GetUserByID([FromRoute] int id)
        {

            var cag = await this.clientRepository.GetUsersByID(id);
            if (cag == null)
            {
                return NotFound();
            }
            return Ok(cag);
        }

        [HttpPost("User/add")]
        public async Task<IActionResult> AddUser([FromBody] Users users)
        {
            var query = await clientRepository.AddUser(users);
            if (query > 0)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpPost("User/update/{id}")]
        public async Task<IActionResult> UpdateUser([FromBody] Users users, [FromRoute] int id)
        {
            await this.clientRepository.UpdateUsers(id, users);
            return Ok(users.User_ID);
        }

        [HttpDelete("User/delete/{id}")]
        public async Task<IActionResult> DeleteUser(Users users, [FromRoute] int id)
        {
            await this.clientRepository.DeleteUsers(id);
            return Ok(users.User_ID);
        }
    }
}
