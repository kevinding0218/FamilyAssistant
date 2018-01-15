using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("SupermarketVegetable")]
    public class SupermarketVegetable : TransLog
    {
        public int SupermarketId { get; set; }
        public int VegeId { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        // one EntreeVegetable could have only one Entree
        public Supermarket Supermarket { get; set; }
        // one EntreeVegetable could have only one Vegetable
        public Vegetable Vege { get; set; }
    }
}