using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("Vegetable")]
    public class Vegetable : TransLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }  
        //public int MealTypeId { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        // one Vegetable could have only one MealType 2
        //public MealType MealType { get; set; }
        // one Vegetable could have many EntreeVegetable
        public ICollection<EntreeVegetable> EntreesWithCurrentVegetable { get; set; }

        public Vegetable()
        {
            //MealTypeId = 2;
        }
    }
}
