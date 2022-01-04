using System.Threading.Tasks;
using ILS.Domain.Entities;
using System.Collections.Generic;

namespace ILS.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task<T> Romove(long id);
        Task<T> Get(long id);
        Task<List<T>> Get();
        
    }
}