using ExampleF1.Models;
using Refit;
using System.Threading.Tasks;

namespace ExampleF1.Services
{
    public interface IApiErgast
    {
        [Get("/api/f1/2018/drivers.json")]
        Task<ApiResponse> GetDrivers();
    }
}