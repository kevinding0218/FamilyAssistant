using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;
using FamilyAssistant.Persistence.IRespository.Meal;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Persistence.Repository.Meal
{
    public class VegetableRepository : IVegetableRepository
    {
        private readonly FaDbContext _context;

        public VegetableRepository(FaDbContext context)
        {
            this._context = context;
        } 

        public async Task<bool> IsDuplicateVegetable(string name)
        {
            return await _context.Vegetables.AnyAsync(v => v.Name == name);
        }

        public async Task<IEnumerable<Vegetable>> GetVegetables() {
            return await _context.Vegetables.ToListAsync ();
        }
        public async Task<Vegetable> GetVegetable(int id)
        {
            return await _context.Vegetables.SingleOrDefaultAsync(v => v.Id == id);
        }

        public void AddVegetable(Vegetable newVegetable)
        {
            _context.Add(newVegetable);
        }

        public void Remove(Vegetable existedVegetable)
        {
            _context.Remove(existedVegetable);
        }
    }
}