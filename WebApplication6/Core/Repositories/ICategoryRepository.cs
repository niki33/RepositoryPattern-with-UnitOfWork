﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6.Core.Repositories
{
 public   interface ICategoryRepository:IRepository<Category>
    {
        IEnumerable<Category> GetTopSellingCategories();
    }
}
