﻿using RAIDPlatform.Data.Repositories.Interfaces;

namespace RAIDPlatform.Data.Repositories.Base
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : IDbContext
    {
        private TContext _context;
        public TContext Context
        {
            get
            {
                return _context;
            }
        }
        public UnitOfWork(TContext context)
        {
            _context = context;
        }
        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}
