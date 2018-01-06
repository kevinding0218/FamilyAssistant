using System.Collections.Generic;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;

namespace FamilyAssistant.Persistence.IRespository.Meal
{
    public interface IVegetableRepository
    {
        Task<bool> IsDuplicateVegetable(string name);
        Task<List<Vegetable>> GetVegetables();
         Task<Vegetable> GetVegetable(int id);
         void AddVegetable(Vegetable newVegetable);
         void Remove(Vegetable existedVegetable);
         Task<int> GetNumberOfEntreesWithVege (int vegeId);
    }
}