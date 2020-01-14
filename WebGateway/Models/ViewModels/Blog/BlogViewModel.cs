namespace Models.ViewModels.Blog
{
    using System.Collections.Generic;

    public class BlogViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<CommentViewModel> Comments { get; set; }

        public string By { get; set; }
    }
}
