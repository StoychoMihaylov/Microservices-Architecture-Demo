namespace Services.Services
{
    using global::Services.Configuration;
    using global::Services.Interfaces;
    using Models.ViewModels.Blog;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class BlogService : IBlogService
    {
        private readonly HttpClient httpClient;
        private readonly MicroserviceConfig micros;
        public BlogService(HttpClient httpClient, MicroserviceConfig micros)
        {
            this.httpClient = httpClient;
            this.micros = micros;
        }

        public async Task<List<BlogViewModel>> GetBlogs()
        {
            var dataResponse = await httpClient.GetStringAsync(micros.BlogAPIService + $"/blog");
            return JsonConvert.DeserializeObject<List<BlogViewModel>>(dataResponse);
        }
    }
}
