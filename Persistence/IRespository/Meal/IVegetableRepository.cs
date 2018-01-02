using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;

namespace FamilyAssistant.Persistence.IRespository.Meal
{
    public interface IVegetableRepository
    {
        Task<bool> IsDuplicateVegetable(string name);
        Task<IEnumerable<Vegetable>> GetVegetables();
         Task<Vegetable> GetVegetable(int id);
         void AddVegetable(Vegetable newVegetable);
         void Remove(Vegetable existedVegetable);
    }
}