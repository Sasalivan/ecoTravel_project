using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLe = BLL.Entities;
using DALe = DAL.Entities;

namespace BLL
{
	static class Mapper
	{
		public static BLLe.Client ToBLL(this DALe.Client entity)
		{
			if (entity is null) return null;
			return new BLLe.Client()
			{
				idClient = entity.idClient,
				nom = entity.nom,
				prenom = entity.prenom,
				mail = entity.mail,
				pays = entity.pays,
				telephone = entity.telephone,
				password = entity.password
			};
		}

		public static DALe.Client ToDAL(this BLLe.Client entity)
		{
			if (entity is null) return null;
			return new DALe.Client()
			{
				idClient = entity.idClient,
				nom = entity.nom,
				prenom = entity.prenom,
				mail = entity.mail,
				pays = entity.pays,
				telephone = entity.telephone,
				password = entity.password
			};
		}

		public static BLLe.Logement ToBLL(this DALe.Logement entity)
		{
			if (entity is null) return null;
			return new BLLe.Logement()
			{
				idLogement = entity.idLogement,
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

		public static DALe.Logement ToDAL(this BLLe.Logement entity)
		{
			if (entity is null) return null;
			return new DALe.Logement()
			{
				idLogement = entity.idLogement,
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

		public static BLLe.Reservation ToBLL(this DALe.Reservation entity)
		{
			if (entity is null) return null;
			return new BLLe.Reservation()
			{
				idReservation = entity.idReservation,
				idClient = entity.idClient,
				idCanceler = entity.idCanceler,
				dateDebut = entity.dateDebut,
				dateFin = entity.dateFin,
				nbPersonne = entity.nbPersonne,
				nbEnfant = entity.nbEnfant,
				dateAnnulation = entity.dateAnnulation,
			};
		}

		public static DALe.Reservation ToDAL(this BLLe.Reservation entity)
		{
			if (entity is null) return null;
			return new DALe.Reservation()
			{
				idReservation = entity.idReservation,
				idClient = entity.idClient,
				idCanceler = entity.idCanceler,
				dateDebut = entity.dateDebut,
				dateFin = entity.dateFin,
				nbPersonne = entity.nbPersonne,
				nbEnfant = entity.nbEnfant,
				dateAnnulation = entity.dateAnnulation,
			};
		}
	}
}
