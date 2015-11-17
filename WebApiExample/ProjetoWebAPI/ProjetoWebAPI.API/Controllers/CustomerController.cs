using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using ProjetoWebAPI.DAL.Model;
using ProjetoWebAPI.DAL.Persistence;

namespace ProjetoWebAPI.API.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        
        public List<Customer> Get()
        {
            CustomerDao cDao = new CustomerDao();
            var list = cDao.GetAll();

            return list;
        }

        // GET: api/Customer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Customer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
        }
    }
}
