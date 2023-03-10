using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecoTravelMVC.Models.ClientModelView
{
    public class ClientListItem
    {
		[DisplayName("identifiant")]
		[ScaffoldColumn(false)]
		public int idClient { get; set; }


		[DisplayName("Nom: ")]
		public string nom { get; set; }


		[DisplayName("Prenom: ")]
		public string prenom { get; set; }


		[DisplayName("Pays: ")]
		public string pays { get; set; }

		[DisplayName("Telephone: ")]
		public string telephone { get; set; }

	}
}
