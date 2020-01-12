namespace ProfileService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels.Profile;
    using Services.Interfaces;
    using System.Threading.Tasks;

    [ApiController]
    [Route("profile")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService service;
        public ProfileController(IProfileService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ProfileViewModel profile = await this.service.GetProfileById(id);

            return Ok(profile);
        }

        [HttpGet]
        [Route("details")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
