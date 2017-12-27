using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyAssistant.Core.Models
{
    [Table("EntreeMeat")]
    public class EntreeMeat : InsertLog
    {
        public int EntreeId { get; set; }
        public int MeatId { get; set; }
        public Entree Entree { get; set; }
        public Meat Meat { get; set; }
        public int Quantity { get; set; }
    }
}
