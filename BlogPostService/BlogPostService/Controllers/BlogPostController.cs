namespace BlogPostService.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Models.ViewModels;
    using Services.Interfaces;

    [ApiController]
    [Route("blog")]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogService service;
        public BlogPostController(IBlogService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var blogs = this.service.GetBlogForProfileWithId();

            return Ok(blogs);
        }
    }
}
