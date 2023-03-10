using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecoTravelMVC.Models.LogementModelView
{
    public class LogementListItem
    {
		[DisplayName("identifiant")]
		[ScaffoldColumn(false)]
		public int idLogement { get; set; }

		[DisplayName("Prix: ")]
		public decimal prix { get; set; }

		[DisplayName("Nom ")]
		public string nom { get; set; }

		[DisplayName("Adresse ")]
		public string adresseRue { get; set; }

		//[DisplayName("numéro ")]
		public string adresseNumero { get; set; }

		//[DisplayName("CP ")]
		public string adresseCodePostal { get; set; }

		//[DisplayName("Pays ")]
		public string adressePays { get; set; }

		[DisplayName("Description courte ")]
		public string desc_courte { get; set; }

		[DisplayName("Description longue ")]
		public string desc_longue { get; set; }

		[DisplayName("chambre ")]
		public int nb_chambre { get; set; }

		[DisplayName("Piece ")]
		public int nb_piece { get; set; }

		[DisplayName("salle de bain ")]
		public int nb_sdb { get; set; }

		[DisplayName("wc ")]
		public int nb_wc { get; set; }

		[DisplayName("nombre de personne peut contenir ")]
		public int capacite { get; set; }

		[DisplayName("Option ")]
		public bool balcon { get; set; }

		public bool airco { get; set; }

		//BIT
		public bool wifi { get; set; }

		//BIT
		public bool minibar { get; set; }

		//BIT
		public bool animaux { get; set; }

		//BIT
		public bool piscine { get; set; }

		//BIT
		public bool voiturier { get; set; }

		//BIT
		public bool roomService { get; set; }

	}
}
