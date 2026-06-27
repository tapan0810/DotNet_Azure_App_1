using DotNet_Azure_App_1.Data;
using DotNet_Azure_App_1.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Azure_App_1.Services
{
    public class AzureUserService (AzureApplicationDbContext _context): IAzureUserService
    {
        public async Task<AzureUser> CreateUserAsync(AzureUser user)
        {
            if(user is null)
            {
                return null;

            }
            await _context.AzureUsers.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public Task<bool> DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AzureUser>> GetAllUsersAsync()
        {
            var users = await _context.AzureUsers.ToListAsync();

            if (users.Count == 0 || users is null)
            {
                return null;
            }

            return users;
        }

        public async Task<AzureUser?> GetUserByIdAsync(int id)
        {
            var user = await _context.AzureUsers.FirstOrDefaultAsync(x => x.Id == id);

            if (user is null)
            {
                return null;
            }

            return user;
        }

        public async Task<AzureUser> UpdateUserAsync(AzureUser user, int id)
        {
            var users = await _context.AzureUsers.FirstOrDefaultAsync(x => x.Id == id);

            if (users is null || user is null)
            {
                return null;
            }

            users.UserName = user.UserName;
            users.UserRole = user.UserRole;
            users.UserEmail = user.UserEmail;
            users.IsActive = user.IsActive;

            await _context.SaveChangesAsync();

            return users;
        }
    }
}
