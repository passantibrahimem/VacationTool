
using Infrastructure.DataBase.Context;

namespace Infrastructure.Repositories
{
    public abstract class BaseRepository
    {
        protected VacationToolContext Context { get; }
        public BaseRepository(VacationToolContext _context)
        {
            this.Context = _context;
        }

    }
}
