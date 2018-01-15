using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FamilyAssistant.Core.Models.Meal;

namespace FamilyAssistant.Core.Models.Shared
{
    [Table("ContactAddress")]
    public class ContactAddress : TransLog
    {
        public int Id { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int ZipCode { get; set; }
        public Supermarket Supermarket { get; set; }
    }
}