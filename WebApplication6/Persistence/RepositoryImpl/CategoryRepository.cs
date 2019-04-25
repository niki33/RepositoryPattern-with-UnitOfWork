using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Core.Repositories;

namespace WebApplication6.Persistence.RepositoryImpl
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductDBEntities context) :base(context) {
        }

        public IEnumerable<Category> GetTopSellingCategories()
        {
            return PContext.Categories.OrderByDescending(c => c.Id);
        }


        public ProductDBEntities PContext {
            get { return Context as ProductDBEntities; }
        }
    }
}