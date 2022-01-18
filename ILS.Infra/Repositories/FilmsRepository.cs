using System.Linq;
using System.Threading.Tasks;
using ILS.Domain.Entities;
using ILS.Infra.Context;
using ILS.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ILS.Infra.Repositories
{
    public class FilmsRepository : BaseRepository<Films>, IFilmsRepository {

        private readonly ILSContext _context;

        public FilmsRepository(ILSContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Films> GetByTitle(string title)
        {
            var films = await _context.Films
                                    .Where
                                    (
                                        x => x.Title.ToLower() == title.ToLower()
                                    )
                                    .AsNoTracking()
                                    .ToListAsync();

            return films.FirstOrDefault();
        }
    }
}