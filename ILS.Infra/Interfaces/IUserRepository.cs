using System.Threading.Tasks;

namespace ILS.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>{
        Task<User> GetByUserCpf(string cpf);
    }
}