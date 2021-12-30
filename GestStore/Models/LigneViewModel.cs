using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GestStore.Models
{
    public class LigneViewModel
    {
        [DisplayName("ID: ")]
        public int LigneID { get; set; }
        [DisplayName("ID Facture: ")]
        public int ComFact { get; set; }
        [DisplayName("ID Produit: ")]
        public int Produit { get; set; }
        [DisplayName("Quantité: ")]
        public int Quantite { get; set; }
        [DisplayName("Prix d'Achat: ")]
        public Decimal PrixAchat { get; set; }

        public LigneViewModel() {  }

        public LigneViewModel(int ligneID, int comFact, int produit, int quantite, decimal prixAchat)
        {
            LigneID = ligneID;
            ComFact = comFact;
            Produit = produit;
            Quantite = quantite;
            PrixAchat = prixAchat;
        }
    }
}
