using CoreApp.Models;

namespace CoreApp.Repositories
{
    public interface IElectorRepository
    {
        Task<Elector> CreateElectorAsync(Elector elector);
    }
}
