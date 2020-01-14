namespace Services.Interfaces
{
    using Models.ViewModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBlogService
    {
        List<BlogViewModel> GetBlogForProfileWithId();
    }
}
