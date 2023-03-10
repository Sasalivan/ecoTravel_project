using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecoTravelMVC.Models.LogementModelView
{
    public class LogementCreateForm
    {
        [Required]
		[DataType(DataType.Currency)]
		[DisplayName("Prix: ")]
		public decimal prix { get; set; }

		[Required]
		[MinLength(2)]
		[DisplayName("Nom du logement: ")]
		public string nom { get; set; }

		//nvarchar(255)
		[Required]
		[MinLength(2)]
		[DisplayName("Rue: ")]
		public string adresseRue { get; set; }

		//nvarchar(15)
		[Required]
		[MinLength(1)]
		[DisplayName("Numero: ")]
		public string adresseNumero { get; set; }

		//nvarchar(8)
		[Required]
		[MinLength(1)]
		[DataType(DataType.PostalCode)]
		[DisplayName("Code Postal: ")]
		public string adresseCodePostal { get; set; }

		//nvarchar(50)
		[Required]
		[MinLength(2)]
		[DisplayName("Pays: ")]
		public string adressePays { get; set; }

		//decimal(10,7)
		[Required]
		[DisplayName("Longitude: ")]
		public decimal longitude { get; set; }

		//deciaml(10,7)
		[Required]
		[DisplayName("Latitude: ")]
		public decimal latitude { get; set; }

		//NVARCHAR(100)
		[Required]
		[MaxLength(100)]
		[DisplayName("Petite description: ")]
		public string desc_courte { get; set; }

		//NVARCHAR(MAX)
		[Required]
		[MinLength(100)]
		[DisplayName("Description plus détaillée: ")]
		public string desc_longue { get; set; }

		//TINYINT
		[Required]
		[DisplayName("Nombre de chambre: ")]
		public int nb_chambre { get; set; }

		//TINYINT
		[Required]
		[DisplayName("Nombre de pièce: ")]
		public int nb_piece { get; set; }

		//TINYINT
		[Required]
		[DisplayName("Nombre de salle de bain: ")]
		public int nb_sdb { get; set; }

		//TINYINT
		[Required]
		[DisplayName("Nombre de toilette: ")]
		public int nb_wc { get; set; }

		//TINYINT
		[Required]
		[DisplayName("Capacité de personne: ")]
		public int capacite { get; set; }

		//BIT
		[Required]
		[DisplayName("Balcon: ")]
		public bool balcon { get; set; } = false;

		//BIT
		[Required]
		[DisplayName("airco: ")]
		public bool airco { get; set; } = false;

		//BIT
		[Required]
		[DisplayName("wifi: ")]
		public bool wifi { get; set; } = false;

		//BIT
		[Required]
		[DisplayName("minibar: ")]
		public bool minibar { get; set; } = false;

		//BIT
		[Required]
		[DisplayName("animaux: ")]
		public bool animaux { get; set; } = true;

		//BIT
		[Required]
		[DisplayName("piscine: ")]
		public bool piscine { get; set; } = false;

		//BIT
		[Required]
		[DisplayName("voiturier: ")]
		public bool voiturier { get; set; } = false;

		//BIT
		[Required]
		[DisplayName("room service: ")]
		public bool roomService { get; set; } = false;

		[ScaffoldColumn(false)]
		public int idProprio { get; set; }
	}
}
