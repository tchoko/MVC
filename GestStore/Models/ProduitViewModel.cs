using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestStore.Models
{
    public class ProduitViewModel
    {
        [DisplayName("ID: ")]
        public int ProduitID { get; set; }
        [DisplayName("Numéro du Produit: ")]
        public int NumProd { get; set; }
        [DataType (DataType.MultilineText)]
        public string Description { get; set; }
        [DisplayName("Prix HTVA: ")]
        public Decimal PrixHtva { get; set; }
        [DisplayName("Quantité en Stock: ")]
        public short Stock { get; set; }

        public ProduitViewModel() { }

        public ProduitViewModel(int produitID, int numProd, string description, Decimal prixHtva, short stock)
        {
            ProduitID = produitID;
            NumProd = numProd;
            Description = description;
            PrixHtva = prixHtva;
            Stock = stock;
        }
    }
}
