using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestStore.Models
{
    public class ClientViewModel
    {
       // [DisplayName("ID: ")]
       // [Key]
        public Guid ClientID { get; set; }
       // [DisplayName ("Nom: ")]
       // [Required(ErrorMessage="Veuillez saisir un nom!")]
        //[StringLength(20,MinimumLength =4)]
        public string Nom { get; set; }
       // [DisplayName("Prénom: ")]
       // [Required(ErrorMessage = "Veuillez saisir un prénom!")]
       // [StringLength(40, MinimumLength = 4)]
        public string Prenom { get; set; }
       // [DisplayName("Code Postal: ")]
       // [Required(ErrorMessage = "Veuillez saisir un Code postal!")]
       // [Range(1000,9999)]
        public int Cp { get; set; }
       // [DisplayName("Localité: ")]
       // [Required(ErrorMessage = "Veuillez saisir une localité!")]
        public string Localite { get; set; }
       // [DisplayName("Rue: ")]
       // [Required(ErrorMessage = "Veuillez saisir une rue!")]
        public string Rue { get; set; }
       // [DisplayName("Numéro: ")]
       // [Required(ErrorMessage = "Veuillez saisir un numéro!")]
        public string Numero { get; set; }
        //[DisplayName("Téléphone: ")]
        public string Tel { get; set; }
        public virtual ICollection<ComFactViewModel> ComFacts { get; set; }

       
    }
}
