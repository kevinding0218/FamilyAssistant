using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Core.Models
{
    [Table("EntreeVegetable")]
    public class EntreeVegetable : InsertLog
    {
        public int EntreeId { get; set; }
        public int VegeId { get; set; }
        public Entree Entree { get; set; }
        public Vegetable Vege { get; set; }
        public int Quantity { get; set; }
    }
}
