using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table("Entree")]
    public class Entree : TransLog
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }

        public ICollection<EntreeVegetable> Vegetables { get; set; }
        public ICollection<EntreeMeat> Meats { get; set; }
        public int? BaseOptionId { get; set; }
        public BaseOption BaseOption { get; set; }

        public Entree()
        {
          Vegetables = new Collection<EntreeVegetable>();
          Meats = new Collection<EntreeMeat>();
          BaseOption = new BaseOption();
        }
    }
}
