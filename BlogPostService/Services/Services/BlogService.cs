namespace Services.Services
{
    using global::Services.Interfaces;
    using Models.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class BlogService : IBlogService
    {
        public List<BlogViewModel> GetBlogForProfileWithId()
        {
            var blogs = CreateBlogs();

            return blogs;
        }

        private List<BlogViewModel> CreateBlogs()
        {
            var blogs = new List<BlogViewModel>()
            {
                new BlogViewModel()
                {
                    Id = 1,
                    Title = "Some Title Here",
                    Description = "Very good content here",
                    By = "Pesho petrohanoveca",
                    Comments = new List<CommentViewModel>()
                    {
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Mnooo qk post bro!",
                             By = "Mendeleev"
                        },
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Dosta dobro!",
                             By = "Strahil"
                        },
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Bravo!",
                             By = "Mehmed"
                        },
                    }
                },
                new BlogViewModel()
                {
                    Id = 1,
                    Title = "Who is the best poker player ?",
                    Description = "Article for poker players!",
                    By = "Meeemed",
                    Comments = new List<CommentViewModel>()
                    {
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Crazy bro!",
                             By = "Mendeleev"
                        },
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "John Bahard is the best player ever!",
                             By = "Ho Uong"
                        },
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "good! Thanks!",
                             By = "Mincho"
                        },
                    }
                },
                new BlogViewModel()
                {
                    Id = 1,
                    Title = "Some crazy good article title here",
                    Description = "Some crazy good description here!",
                    By = "Sexy_14",
                    Comments = new List<CommentViewModel>()
                    {
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Very goood!",
                             By = "Mimi_2001"
                        },
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Baaaam!!!! Congrats!",
                             By = "Bibo_sexy_baby_2008"
                        },
                        new CommentViewModel()
                        {
                             Id = 1,
                             Content = "Wow! That's it!",
                             By = "sexy_cat_11"
                        },
                    }
                },
            };

            return blogs;
        }
    }
}
