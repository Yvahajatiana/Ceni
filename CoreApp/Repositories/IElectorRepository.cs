using CoreApp.Models;

namespace CoreApp.Repositories
{
    public interface IElectorRepository
    {
        Task CreateElectorAsync(Elector elector);
    }
}
