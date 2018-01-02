using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Core.Models.Meal
{
    public class BaseOption : TransLog
  {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Entree> Entrees { get; set; }
    }
}