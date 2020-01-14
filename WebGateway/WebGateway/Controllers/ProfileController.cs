namespace WebGateway.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels.Blog;
    using Models.ViewModels.Profile;
    using Services.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [ApiController]
    [Route("profile")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService profileService;
        private readonly IBlogService blogService;
        public ProfileController(IProfileService profileService, IBlogService blogService)
        {
            this.profileService = profileService;
            this.blogService = blogService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ProfileViewModel profile = await this.profileService.GetProfileById(id);
            List<BlogViewModel> blogs = await this.blogService.GetBlogs();

            profile.Blogs = blogs;

            return Ok(profile);
        }
    }
}
