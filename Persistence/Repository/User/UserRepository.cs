using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FamilyAssistant.Persistence.IRespository.User;

namespace FamilyAssistant.Persistence.Repository.User {
    public class UserRepository : IUserRepository
    {
        private readonly FaDbContext _context;
        public UserRepository (FaDbContext context) {
            this._context = context;

        }
        public async Task<bool> IsExistedUser (int userId) {
            return await _context.Users.AnyAsync (u => u.UserID == userId);
        }
    }
}