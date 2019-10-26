using System.Threading.Tasks;
using Backomm.Models;

namespace Backomm.Services
{
    public interface IAuthService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        Task<AuthenticationResult> LoginAsync(string email, string password);   
    }
}