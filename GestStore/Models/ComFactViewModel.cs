using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestStore.Models
{
    public class ComFactViewModel
    {
        [DisplayName("ID Commande: ")]
        public int NumCommande { get; set; }
        [DisplayName("ID Facture: ")]
        public int NumFact { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Date Commande: ")]
        [DisplayFormat (DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCom { get; set; }
        [DisplayName("Etat: ")]
        public string Etat { get; set; }
        [DisplayName("Montant: ")]
        public int Montant { get; set; }
        [DisplayName("ID du Client: ")]
        public int idclient { get; set; }

        public ComFactViewModel() { }
        public ComFactViewModel(int numCommande, int numFact, DateTime dateCom, string etat, int montant)
        {
            NumCommande = numCommande;
            NumFact = numFact;
            DateCom = dateCom;
            Etat = etat;
            Montant = montant;
        }
        public ComFactViewModel(int numCommande, int numFact, DateTime dateCom, string etat, int montant, int idclient)
        {
            NumCommande = numCommande;
            NumFact = numFact;
            DateCom = dateCom;
            Etat = etat;
            Montant = montant;
            this.idclient = idclient;
        }

    }

}
