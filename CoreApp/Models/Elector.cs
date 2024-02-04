using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class Elector
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string VoterCardNumber { get; set; }
        public string IdCardNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public string District { get; set; }
        public int DistrictId { get; set; }
        public string Region { get; set; }
        public int RegionId { get; set; }
        public int PostalCode { get; set; }
    }
}
