using System.Linq;
using System.Threading.Tasks;
using ILS.Domain.Entities;
using ILS.Infra.Context;
using ILS.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ILS.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository {

        private readonly ILSContext _context;

        public UserRepository(ILSContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetByUserCpf(string cpf)
        {
            var user = await _context.Users
                                    .Where
                                    (
                                        x => x.Cpf.ToLower() == cpf.ToLower()
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return user.FirstOrDefault();
        }
    }
}