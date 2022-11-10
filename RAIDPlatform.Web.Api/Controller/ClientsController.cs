using Microsoft.AspNetCore.Mvc;
using RAIDPlatform.Data.Model.Client;
using RAIDPlatform.Data.Model.Client.Client_Application_Category;
using RAIDPlatform.Data.Model.Client.Clients;
using RAIDPlatform.Data.Model.Master.Applications;
using RAIDPlatform.Data.Repositories.Interfaces;
using RAIDPlatform.Data.Repositories.Repositories;


namespace RAIDPlatform.Web.Api.Controller
{

    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository clientRepository;
        public ClientsController(IClientRepository _clientRepo)
        {
            this.clientRepository = _clientRepo;
        }

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
        
        [HttpGet("client-application-category-all")]
        public async Task<IActionResult> GetAllClientApplicationCategory()
        {
            var query = await clientRepository.GetAllClientApplicationCategory();
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

        [HttpPost("add/Client-Application-Category")]
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
        
        [HttpGet("client-application-security-group-all")]
        public async Task<IActionResult> GetAllClientApplicationSecurityGroup()
        {
            var query = await clientRepository.GetAllClientApplicationSecurityGroup();
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

        [HttpPost("add/Client-Application-Security-Group")]
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
    }
}
