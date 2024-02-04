using CoreApp.Models;
using CoreApp.Repositories;

namespace CoreApp.Services
{
    public interface IRegistrationService
    {
        Task RegisterElector(Elector elector);
    }
    public class RegistrationService : IRegistrationService
    {
        private readonly IElectorRepository electorRepository;

        public RegistrationService(IElectorRepository electorRepository) 
        {
            this.electorRepository = electorRepository;
        }

        public async Task RegisterElector(Elector elector)
        {
            await electorRepository.CreateElectorAsync(elector);
        }
    }
}
