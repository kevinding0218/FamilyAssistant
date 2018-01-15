using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;
using FamilyAssistant.Extensions;
using FamilyAssistant.Persistence.IRespository.Meal;
using Microsoft.EntityFrameworkCore;

namespace FamilyAssistant.Persistence.Repository.Meal
{
    public class MeatRepository : IMeatRepository
    {
        private readonly FaDbContext _context;

        public MeatRepository (FaDbContext context) {
            this._context = context;
        }

        public async Task<bool> IsDuplicateMeat (string name) {
            return await _context.Meats.AnyAsync (m => m.Name == name);
        }

        public async Task<IEnumerable<Meat>> GetMeats () {
            return await this. _context.Meats.ToListAsync();
        }

        public async Task<Meat> GetMeat (int id) {
            return await _context.Meats.SingleOrDefaultAsync (m => m.Id == id);
        }

        public void AddMeat (Meat newMeat) {
            _context.Add (newMeat);
        }

        public void Remove (Meat existedMeat) {
            _context.Remove (existedMeat);
        }

        public async Task<int> GetNumberOfEntreesWithMeat (int meatId) {
            // Use Store Procedure         
            int numberOfEntreeWithVege = -1;

            await _context.LoadStoredProc ("dbo.GetNumberOfEntreeById")
                .WithSqlParam ("Id", meatId)
                .WithSqlParam ("Type", "Meat")
                .ExecuteStoredProcAsync ((handler) => {
                    numberOfEntreeWithVege = handler.ReadToValue<int> () ?? default (int);;
                    // do something with your results.
                }); 

            return numberOfEntreeWithVege;
        }
    }
}