using DotNet_Azure_App_1.Models;

namespace DotNet_Azure_App_1.Services
{
    public interface IAzureUserService
    {
        public Task<IEnumerable<AzureUser>> GetAllUsersAsync();
        public Task<AzureUser?> GetUserByIdAsync(int id);
        public Task<AzureUser> CreateUserAsync(AzureUser user);
        public Task<AzureUser> UpdateUserAsync(AzureUser user);
        public Task<bool> DeleteUserAsync(int id);
    }
}
