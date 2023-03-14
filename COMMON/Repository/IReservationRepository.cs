using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Repository
{
	public interface IReservationRepository<TEntity, TId> : IRepository<TEntity, TId>
	{
		IEnumerable<TEntity> GetByClient(int idClient);
		IEnumerable<TEntity> GetByDateDebut(DateTime dateDebut);
		IEnumerable<TEntity> GetByDate(DateTime dateFin);

		IEnumerable<TEntity> GetByDateAnnulation(DateTime dateAnnulation);


	}
}
