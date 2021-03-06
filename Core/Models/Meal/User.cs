using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FamilyAssistant.Core.Models.Shared;

namespace FamilyAssistant.Core.Models.Meal
{
    [Table ("Users")]
    public class User : TransLog
    {
        public int UserID { get; set; }

        [Required]
        [StringLength (100)]
        [Column(Order = 1)]
        public string Email { get; set; }

        [StringLength (30)]
        [Column(Order = 2)]
        public string FirstName { get; set; }

        [StringLength (30)]
        [Column(Order = 3)]
        public string LastName { get; set; }

        [Column(Order = 4)]
        public bool? IsFAUser { get; set; }

        [Column(Order = 5)]
        public DateTime LastLogIn { get; set; }
        [StringLength(255)]
        public string Note { get; set; }

        public User()
        {
            
        }
    }
}