using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication6.Persistence;
using WebApplication6.Persistence.RepositoryImpl;

namespace WebApplication6.Controllers
{
    public class ValuesController : ApiController
    {
        protected ProductDBEntities context;
        // GET api/values
        public IEnumerable<Product> Get()
        {
            context = new ProductDBEntities();
            using (var unitofwork = new UnitOfWork(context))
            {
           return     unitofwork.product.GetAll();
            }

            //context= new ProductDBEntities();
            //Repository <Product> p= new  Repository<Product>(context);
            //return p.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
