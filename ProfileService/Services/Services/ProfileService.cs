namespace Services.Services
{
    using global::Services.Interfaces;
    using Models.ViewModels.Profile;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ProfileService : IProfileService
    {
        public async Task<ProfileViewModel> GetProfileById(int id)
        {
            var fakeDB = new List<ProfileViewModel>()
            {
                new ProfileViewModel()
                {
                    Id = 1,
                    Name = "Gosho",
                    Age = 25,
                    Bio = "Dancer, Poet and Hustler"
                },
                new ProfileViewModel()
                {
                    Id = 2,
                    Name = "Pesho",
                    Age = 31,
                    Bio = "Software Engineer"
                },
                new ProfileViewModel()
                {
                    Id = 3,
                    Name = "Petrohan",
                    Age = 25,
                    Bio = "Kloshar"
                },
            };

            return fakeDB
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }
    }
}
