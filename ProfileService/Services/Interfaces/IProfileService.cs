namespace Services.Interfaces
{
    using Models.ViewModels.Profile;
    using System.Threading.Tasks;

    public interface IProfileService
    {
        Task<ProfileViewModel> GetProfileById(int id);
    }
}
