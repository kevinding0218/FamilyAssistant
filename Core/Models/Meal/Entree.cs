using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("Entree")]
    public class Entree : TransLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        //public int MealTypeId { get; set; }
        public int? StapleFoodId { get; set; }
        [StringLength(255)]
        public String Note { get; set; }
        public int? CurrentRank { get; set; }

        // one Entree could have only one MealType
        //public MealType MealType { get; set; }
        // one Entree could have many EntreeVegetable
        public ICollection<EntreeVegetable> VegetablesWithCurrentEntree { get; set; }
        // one Entree could have many EntreeMeat
        public ICollection<EntreeMeat> MeatsWithCurrentEntree { get; set; }
        // one Entree could have only one or null StapleFood
        public virtual StapleFood StapleFood { get; set; }
        
        public Entree()
        {
          VegetablesWithCurrentEntree = new Collection<EntreeVegetable>();
          MeatsWithCurrentEntree = new Collection<EntreeMeat>();
          StapleFood = new StapleFood();
          //MealTypeId = 1;
        }
    }
}
