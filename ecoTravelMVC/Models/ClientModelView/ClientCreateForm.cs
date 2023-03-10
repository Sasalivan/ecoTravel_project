using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ecoTravelMVC.Models.ClientModelView
{
    public class ClientCreateForm
    {
		[Required]
		[MaxLength(50)]
		[MinLength(2)]
		[DisplayName("Nom: ")]
		public string nom { get; set; }


		[Required]
		[MaxLength(50)]
		[MinLength(2)]
		[DisplayName("Prénom: ")]
		public string prenom { get; set; }


		[Required]
		[MaxLength(250)]
		[MinLength(5)]
		[EmailAddress]
		[DisplayName("Adresse mail: ")]
		public string mail { get; set; }


		[Required]
		[MaxLength(50)]
		[MinLength(3)]
		[DisplayName("Pays: ")]
		public string pays { get; set; }


		[Required]
		[DataType(DataType.PhoneNumber)]
		[DisplayName("Numero de téléphone: ")]
		public string telephone { get; set; }


		[Required]
		[MaxLength(64)]
		[MinLength(6)]
		[DataType(DataType.Password)]
		[DisplayName("Mot de passe: ")]
		public string password { get; set; }
	}
}
