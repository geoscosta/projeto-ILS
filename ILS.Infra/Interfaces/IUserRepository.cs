using System.Threading.Tasks;
using ILD.Domain.Entities;

namespace ILS.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>{
        Task<User> GetByUserCpf(string cpf);
    }
}