using System.Threading.Tasks;
using ILS.Domain.Entities;

namespace ILS.Infra.Interfaces
{
    public interface IFilmsRepository : IBaseRepository<Films>{
        Task<Films> GetByTitle(string title);
    }
}