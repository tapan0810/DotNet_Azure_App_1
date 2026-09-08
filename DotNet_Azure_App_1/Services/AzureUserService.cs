using DotNet_Azure_App_1.Data;
using DotNet_Azure_App_1.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Azure_App_1.Services
{
    public class AzureUserService(AzureApplicationDbContext _context) : IAzureUserService
    {
        public async Task<AzureUser> CreateUserAsync(AzureUser user)
        {
            ArgumentNullException.ThrowIfNull(user);

            await _context.AzureUsers.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var user = await _context.AzureUsers.FirstOrDefaultAsync(x => x.Id == id);
            if (user is null)
            {
                return false;
            }

            _context.AzureUsers.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<AzureUser>> GetAllUsersAsync()
        {
            return await _context.AzureUsers.AsNoTracking().ToListAsync();
        }

        public async Task<AzureUser?> GetUserByIdAsync(int id)
        {
            return await _context.AzureUsers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<AzureUser> UpdateUserAsync(AzureUser user, int id)
        {
            ArgumentNullException.ThrowIfNull(user);

            var existingUser = await _context.AzureUsers.FirstOrDefaultAsync(x => x.Id == id);
            if (existingUser is null)
            {
                return null!;
            }

            existingUser.UserName = user.UserName;
            existingUser.UserRole = user.UserRole;
            existingUser.UserEmail = user.UserEmail;
            existingUser.IsActive = user.IsActive;

            await _context.SaveChangesAsync();
            return existingUser;
        }
    }
}
