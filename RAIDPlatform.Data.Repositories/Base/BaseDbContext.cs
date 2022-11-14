using Microsoft.EntityFrameworkCore;
using RAIDPlatform.Data.Repositories.Interfaces;

namespace RAIDPlatform.Data.Repositories.Base
{
    public class BaseDbContext<T> : DbContext, IDbContext where T : DbContext
    {
        public BaseDbContext(DbContextOptions<T> options) : base(options)
        { }

        public DbContext GetContext()
        {
            return this;
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
