using ExampleF1.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleF1.Services
{
    public class ApiService
    {
        private readonly IApiErgast _api;

        public ApiService()
        {
            _api = RestService.For<IApiErgast>("https://ergast.com");
        }

        public async Task<List<Driver>> GetDrivers()
        {
            var response = await _api.GetDrivers();
            return response.MRData.DriverTable.Drivers;
        }
    }
}