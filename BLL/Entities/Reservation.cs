using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
	public class Reservation
	{
		//INT
		public int idReservation { get; set; }

		//INT
		public int idClient { get; set; }

		//INT
		public int idCanceler { get; set; }

		//date
		public DateTime dateDebut { get; set; }

		//date
		public DateTime dateFin { get; set; }

		//tinyInt
		public int nbPersonne { get; set; }

		//tinyInt
		public int nbEnfant { get; set; }

		//dateTime
		public DateTime dateAnnulation { get; set; }
	}
}
