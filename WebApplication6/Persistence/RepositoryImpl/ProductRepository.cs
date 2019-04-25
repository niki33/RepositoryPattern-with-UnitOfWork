using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Core.Repositories;

namespace WebApplication6.Persistence.RepositoryImpl
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductDBEntities context) : base(context)
        {
        }

        public IEnumerable<Product> GetTopSellingProduct()
        {
        return   PContext.Products.OrderByDescending(c => c.Price);
        }

        public ProductDBEntities PContext
        {
            get { return Context as ProductDBEntities;}
        }
    }
}