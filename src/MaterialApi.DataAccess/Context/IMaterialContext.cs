using System.Linq;
using MaterialApi.Entities;

namespace MaterialApi.DataAccess
{
    public interface IMaterialContext
    {
        IQueryable<Worker> Workers { get; set; }
        T Create<T>(T entity) where T : BaseEntity;
    }
}
