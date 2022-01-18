using System.Threading.Tasks;
using ILS.Domain.Entities;

namespace ILS.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>{
        Task<User> GetByUserCpf(string cpf);
    }
}