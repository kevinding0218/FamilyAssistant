using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("EntreeIngredient")]
    public class EntreeIngredient : TransLog
    {
        public int EntreeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        [StringLength(255)]
        public string Note { get; set; }

        
        // one EntreeIngredient could have only one Entree
        public Entree Entree { get; set; }
        // one EntreeIngredient could have only one Ingredient
        public Ingredient Ingredient { get; set; }
    }
}
