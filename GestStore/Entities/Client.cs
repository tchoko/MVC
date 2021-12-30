using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestStore.Entities
{
    public class Client
    {
        [Key]
        public Guid ClientID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Nom { get; set; }
        [StringLength(40, MinimumLength = 4)]
        public string Prenom { get; set; }
        [Range(1000, 9999)]
        public int Cp { get; set; }
        public string Localite { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string Tel { get; set; }
    }
}
