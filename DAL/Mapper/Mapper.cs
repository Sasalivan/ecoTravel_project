using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
	static class Mapper
	{
		public static Client ToClient(this IDataRecord record)
		{
			if (record is null) return null;
			return new Client()
			{
				idClient = (int)record[nameof(Client.idClient)],
				nom = (string)record[nameof(Client.nom)],
				prenom = (string)record[nameof(Client.prenom)],
				mail = (string)record[nameof(Client.mail)],
				pays = (string)record[nameof(Client.pays)],
				telephone = (string)record[nameof(Client.telephone)],
				password = "******"
			};
		}

		public static Logement ToLogement(this IDataRecord record)
		{
			if (record is null) return null;
			return new Logement()
			{
				idLogement = (int)record[nameof(Logement.idLogement)],
				prix = (decimal)record[nameof(Logement.prix)],
				nom = (string)record[nameof(Logement.nom)],
				adresseRue = (string)record[nameof(Logement.adresseRue)],
				adresseNumero = (string)record[nameof(Logement.adresseNumero)],
				adresseCodePostal = (string)record[nameof(Logement.adresseCodePostal)],
				adressePays = (string)record[nameof(Logement.adressePays)],
				longitude = (decimal)record[nameof(Logement.longitude)],
				latitude = (decimal)record[nameof(Logement.latitude)],
				desc_courte = (string)record[nameof(Logement.desc_courte)],
				desc_longue = (string)record[nameof(Logement.desc_longue)],
				nb_chambre = (int)record[nameof(Logement.nb_chambre)],
				nb_piece = (int)record[nameof(Logement.nb_piece)],
				nb_sdb = (int)record[nameof(Logement.nb_sdb)],
				nb_wc = (int)record[nameof(Logement.nb_wc)],
				capacite = (int)record[nameof(Logement.capacite)],
				balcon = (bool)record[nameof(Logement.balcon)],
				airco = (bool)record[nameof(Logement.airco)],
				wifi = (bool)record[nameof(Logement.wifi)],
				minibar = (bool)record[nameof(Logement.minibar)],
				animaux = (bool)record[nameof(Logement.animaux)],
				piscine = (bool)record[nameof(Logement.piscine)],
				voiturier = (bool)record[nameof(Logement.voiturier)],
				roomService = (bool)record[nameof(Logement.roomService)],
				idProprio = (int)record[nameof(Logement.idProprio)]
			};
		}


		public static Reservation ToReservation(this IDataRecord record)
		{
			if (record is null) return null;
			return new Reservation()
			{
				idReservation = (int)record[nameof(Reservation.idReservation)],
				idClient = (int)record[nameof(Reservation.idClient)],
				idCanceler = (int)record[nameof(Reservation.idCanceler)],
				dateDebut = (DateTime)record[nameof(Reservation.dateDebut)],
				dateFin = (DateTime)record[nameof(Reservation.dateFin)],
				nbPersonne = (int)record[nameof(Reservation.nbPersonne)],
				nbEnfant = (int)record[nameof(Reservation.nbEnfant)],
				dateAnnulation = (DateTime)record[nameof(Reservation.dateAnnulation)]
			};
		}
	}
}
