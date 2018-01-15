using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("Ingredient")]
    public class Ingredient : TransLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }  
        [StringLength(255)]
        public string Note { get; set; }
        // one Ingredient could have many EntreeIngredient
        public ICollection<EntreeIngredient> EntreesWithCurrentIngredient { get; set; }
    }
}
