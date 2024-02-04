using CoreApp.Models;
using CoreApp.Repositories;
using Dapper;

namespace DataAccess.Repositories
{
    public class ElectorRepository : IElectorRepository
    {
        private readonly DapperContext _context;

        public ElectorRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateElectorAsync(Elector elector)
        {
            var query = "INSERT INTO [dbo].[Elector] ([NameSingleFormat] , [FirstName] , [LastName] , [VoterCardNumber] , [IdCardNumber] , [Email] , [Phone] , [Address] , [CityId] , [RegionId] , [PostalCode] , [DistrictId]) VALUES (@NameSingleFormat ,@FirstName ,@LastName ,@VoterCardNumber ,@IdCardNumber ,@Email ,@Phone ,@Address ,@CityId ,@RegionId ,@PostalCode ,@DistrictId)";

            var parameters = new DynamicParameters();
            parameters.Add("NameSingleFormat", elector.FirstName);
            parameters.Add("FirstName", elector.FirstName);
            parameters.Add("LastName", elector.LastName);
            parameters.Add("VoterCardNumber", elector.VoterCardNumber);
            parameters.Add("IdCardNumber", elector.IdCardNumber);
            parameters.Add("Email", elector.Email);
            parameters.Add("Phone", elector.Phone);
            parameters.Add("Address", elector.Address);
            parameters.Add("CityId", elector.CityId);
            parameters.Add("RegionId", elector.RegionId);
            parameters.Add("PostalCode", elector.PostalCode);
            parameters.Add("DistrictId", elector.DistrictId);

            using (var dbConnection = _context.CreateConnection())
            {
                await dbConnection.ExecuteAsync(query, parameters);
            }
        }
    }
}
