using BLL.Entities;
using ecoTravelMVC.Models.ClientModelView;
using ecoTravelMVC.Models.LogementModelView;

namespace ecoTravelMVC.Handlers
{
    public static class Mapper
    {
        public static ClientListItem ToListItem(this BLL.Entities.Client entity)
        {
			if (entity is null) return null;
			return new ClientListItem()
			{
				idClient = entity.idClient,
				nom = entity.nom,
				prenom = entity.prenom,
				pays = entity.pays,
				telephone = entity.telephone
			};
		}

		public static Client ToBLL(this ClientCreateForm entity)
		{
			if (entity is null) return null;
			return new Client()
			{
				nom = entity.nom,
				prenom = entity.prenom,
				mail = entity.mail,
				pays = entity.pays,
				telephone = entity.telephone,
				password = entity.password
			};
		}


		public static LogementListItem ToListItem(this BLL.Entities.Logement entity)
		{
			if (entity is null) return null;
			return new LogementListItem()
			{
				idLogement = entity.idLogement,
				prix = entity.prix,
				nom = entity.nom,
				adresseRue = entity.adresseRue,
				adresseNumero = entity.adresseNumero,
				adresseCodePostal = entity.adresseCodePostal,
				adressePays = entity.adressePays,
				desc_courte = entity.desc_courte,
				desc_longue = entity.desc_longue,
				nb_chambre = entity.nb_chambre,
				nb_piece = entity.nb_piece,
				nb_sdb = entity.nb_sdb,
				nb_wc = entity.nb_wc,
				capacite = entity.capacite,
				balcon = entity.balcon,
				airco = entity.airco,
				wifi = entity.wifi,
				minibar = entity.minibar,
				animaux = entity.animaux,
				piscine = entity.piscine,
				voiturier = entity.voiturier,
				roomService = entity.roomService
			};
		}

		public static Logement ToBLL(this LogementCreateForm entity)
		{
			if (entity is null) return null;
			return new Logement()
			{
				prix = entity.prix,
				nom = entity.nom,
				adresseRue = entity.adresseRue,
				adresseNumero = entity.adresseNumero,
				adresseCodePostal = entity.adresseCodePostal,
				adressePays = entity.adressePays,
				longitude = entity.longitude,
				latitude = entity.latitude,
				desc_courte = entity.desc_courte,
				desc_longue = entity.desc_longue,
				nb_chambre = entity.nb_chambre,
				nb_piece = entity.nb_piece,
				nb_sdb = entity.nb_sdb,
				nb_wc = entity.nb_wc,
				capacite = entity.capacite,
				balcon = entity.balcon,
				airco = entity.airco,
				wifi = entity.wifi,
				minibar = entity.minibar,
				animaux = entity.animaux,
				piscine = entity.piscine,
				voiturier = entity.voiturier,
				roomService = entity.roomService,
				idProprio = entity.idProprio
			};
		}
	}
}
