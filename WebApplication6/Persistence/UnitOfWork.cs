using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Core;
using WebApplication6.Core.Repositories;
using WebApplication6.Persistence.RepositoryImpl;

namespace WebApplication6.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProductDBEntities _context;
        public UnitOfWork(ProductDBEntities Context)
        {
            _context = Context;
            category= new CategoryRepository(_context);
            product= new ProductRepository(_context);
        }

        public ICategoryRepository category { get; private set; }

        public IProductRepository product { get; private set; }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}