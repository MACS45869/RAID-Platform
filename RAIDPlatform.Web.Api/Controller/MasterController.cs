using Microsoft.AspNetCore.Mvc;
using RAIDPlatform.Data.Models.Master.Applications;
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
        
        [HttpGet("Application/getById/{id}")]
        public async Task<IActionResult> GetAppByID([FromRoute] int id)
        {

            var app = await this.masterRepository.GetApplicationByID(id);
            if (app == null)
            {
                return NotFound();
            }
            return Ok(app);
        }
       
        [HttpPost("add-application")]
        public async Task<IActionResult> AddApplication([FromBody] Applications applications)
        {
            var query = await masterRepository.AddApplicationAsync(applications);
            if (query > 0)
                return Ok(query);
            else
                return BadRequest(query);
        }

        [HttpPost("Application/update/{id}")]
        public async Task<IActionResult> UpdateApp([FromBody] Applications applications, [FromRoute] int id)
        {
            await this.masterRepository.UpdateApplication(id, applications);
            return Ok(applications.Application_ID);
        }

        [HttpDelete("Application/delete/{id}")]
        public async Task<IActionResult> DeleteApplication([FromRoute] int id)
        {
            await this.masterRepository.DeleteApplication(id);
            return Ok();
        }
    }
}
