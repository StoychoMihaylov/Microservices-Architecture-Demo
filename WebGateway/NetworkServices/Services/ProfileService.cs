namespace Services.Serives
{
    using global::Services.Configuration;
    using global::Services.Interfaces;
    using Models.ViewModels.Profile;
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Threading.Tasks;
    public class ProfileService : IProfileService
    {
        private readonly HttpClient httpClient;
        private readonly MicroserviceConfig micros;
        public ProfileService(HttpClient httpClient, MicroserviceConfig micros)
        {
            this.httpClient = httpClient;
            this.micros = micros;
        }

        public async Task<ProfileViewModel> GetProfileById(int id)
        {
            var dataResponse = await httpClient.GetStringAsync(micros.ProfileAPIService + $"/profile/{id}");
            return JsonConvert.DeserializeObject<ProfileViewModel>(dataResponse);
        }
    }
}
