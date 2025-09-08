using PageNest.DataAccess.Data;
using PageNest.DataAccess.Repository.IRepository;
using PageNest.Models;

namespace PageNest.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
