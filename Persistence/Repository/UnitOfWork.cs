using System.Threading.Tasks;
using FamilyAssistant.Persistence.IRespository;

namespace FamilyAssistant.Persistence.Repository {
    public class UnitOfWork : IUnitOfWork {
        private readonly FaDbContext _context;
        public UnitOfWork (FaDbContext context) {
            this._context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}