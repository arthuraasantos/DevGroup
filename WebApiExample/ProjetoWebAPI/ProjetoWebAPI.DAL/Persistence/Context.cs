
using System.Configuration;
using System.Data.Entity;
using ProjetoWebAPI.DAL.Model;

namespace ProjetoWebAPI.DAL.Persistence
{
    public class Context: DbContext
    {
        public Context()
            :base(ConfigurationManager.ConnectionStrings["WebapiExample"].ConnectionString)
        {
         
        }

        public DbSet<Customer> SetCustomer { get; set; } 

    }
}
