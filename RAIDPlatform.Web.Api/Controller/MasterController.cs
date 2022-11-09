using Microsoft.AspNetCore.Mvc;
using RAIDPlatform.Data.Model.Master.Applications;
using RAIDPlatform.Data.Repositories.Interfaces;

namespace RAIDPlatform.Web.Api.Controller
{

    public class MasterController : ControllerBase
    {
        private readonly IMasterRepository masterRepository;
        public MasterController(IMasterRepository _masterRepo)
        {
            this.masterRepository = _masterRepo;
        }

        [HttpGet("app-all")]
        public async Task<IActionResult> GetAllApplications()
        {
            var query = await masterRepository.GetAllApplications();
            if (query != null)
                return Ok(query);
            else
                return BadRequest(query);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppByID([FromRoute] int id)
        {

            var books = await this.masterRepository.GetApplicationByID(id);
            if (books == null)
            {
                return NotFound();
            }
            return Ok(books);
        }
       
        [HttpPost("add-app")]
        public async Task<IActionResult> AddStudent([FromBody] Applications applications)
        {
            var query = await masterRepository.AddApplicationAsync(applications);
            if (query > 0)
                return Ok(query);
            else
                return BadRequest(query);
        }
    }
}
