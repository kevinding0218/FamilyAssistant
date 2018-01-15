using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FamilyAssistant.Core.Models.Meal
{
    public class MealType
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Type { get; set; }
        /* 
        // one MealType could have many Entree
        public ICollection<Entree> Entrees { get; set; }
        // one MealType could have many Vegetable
        public ICollection<Vegetable> Vegetables { get; set; }
        // one MealType could have many Meat
        public ICollection<Meat> Meats { get; set; }
        // one MealType could have many StapleFood
        public ICollection<StapleFood> StapleFoods { get; set; } */
    }
}