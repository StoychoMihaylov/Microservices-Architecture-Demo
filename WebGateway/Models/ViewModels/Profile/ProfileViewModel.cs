namespace Models.ViewModels.Profile
{
    using Models.ViewModels.Blog;
    using System.Collections.Generic;
    public class ProfileViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Bio { get; set; }

        public List<BlogViewModel> Blogs { get; set; }
    }
}
