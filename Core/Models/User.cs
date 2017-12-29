using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAssistant.Core.Models
{
    [Table ("Users")]
    public class User : InsertLog {
        public int UID { get; set; }

        [Required]
        [StringLength (100)]
        public string Email { get; set; }

        [StringLength (30)]
        public string FirstName { get; set; }

        [StringLength (30)]
        public string LastName { get; set; }

        public bool? IsFAUser { get; set; }

        public DateTime LastLogIn { get; set; }
    }
}