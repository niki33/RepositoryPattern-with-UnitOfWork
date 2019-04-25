using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication6.Core.Repositories;

namespace WebApplication6.Core
{
    interface IUnitOfWork:IDisposable
    {
    ICategoryRepository category { get;  }
    IProductRepository product { get; }

    int Complete();

    }
}
