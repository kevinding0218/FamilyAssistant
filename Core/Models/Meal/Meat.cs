using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("Meat")]
    public class Meat : TransLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        //public int MealTypeId { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        // one Meat could have only one MealType 3
        //public MealType MealType { get; set; }
        // one Meat could have many EntreeMeat
        public ICollection<EntreeMeat> EntreesWithCurrentMeat { get; set; }

        public Meat()
        {
            //MealTypeId = 3;
        }

    }
}
