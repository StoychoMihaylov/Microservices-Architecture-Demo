using Models.ViewModels.Blog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBlogService
    {
        Task<List<BlogViewModel>> GetBlogs();
    }
}
