using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Repository
{
	public interface ILogementRepository<TEntity, TId> : IRepository<TEntity, TId>
	{
		IEnumerable<TEntity> GetByProprio(int idProprio);
	}
}
