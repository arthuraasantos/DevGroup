

using System.Collections.Generic;
using System.Linq;
using ProjetoWebAPI.DAL.Model;

namespace ProjetoWebAPI.DAL.Persistence
{
    public class CustomerDao : Context
    {
        private Context Context { get; set; }
        public CustomerDao()
        {
            Context = new Context();
        }

        public List<Customer> GetAll()
        {
            return Context.SetCustomer.ToList();
        } 

        
    }
}
