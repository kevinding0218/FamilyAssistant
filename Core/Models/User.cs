using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyAssistant.Core.Models
{
    [Table ("Users")]
    public class User {

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

        public ICollection<Vegetable> AddedVegetables { get; set; }
        public ICollection<Meat> AddedMeats { get; set; }
        public ICollection<Entree> AddedEntrees { get; set; }
        public ICollection<EntreeVegetable> AddedEntreeVegetables { get; set; }
        public ICollection<EntreeMeat> AddedEntreeMeats { get; set; }
        public ICollection<BaseOption> AddedBaseOptions { get; set; }
    }
}