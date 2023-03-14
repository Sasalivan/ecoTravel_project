using BLL.Entities;
using COMMON.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
	public class ReservationService
	{
		private readonly IReservationRepository<DAL.Entities.Reservation, int> _repository;

		public ReservationService(IReservationRepository<DAL.Entities.Reservation, int> repository)
		{
			_repository = repository;
		}

		public IEnumerable<Reservation> Get()
		{
			return _repository.Get().Select(e => e.ToBLL());
		}
		public Reservation Get(int id)
		{
			return _repository.Get(id).ToBLL();
		}

		public int Insert(Reservation entity)
		{
			return _repository.Insert(entity.ToDAL());
		}

		public bool Update(int id, Reservation entity)
		{
			return _repository.Update(id, entity.ToDAL());
		}
	}
}
