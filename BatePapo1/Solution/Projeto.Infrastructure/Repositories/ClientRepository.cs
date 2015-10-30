using Projeto.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.Remoting;


namespace Projeto.Infrastructure.Repositories
{
    public class ClientRepository
    {
        public SqlConnection _dbConn;
        public SqlCommand _cmd;
        public SqlDataReader _dr;
        public ClientRepository()
        {
            _dbConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }

        public void Insert(Client c)
        {
            try
            {
                var sql = "Insert into Client(Name, Email) values (@Name,@Email) ";
                _cmd = new SqlCommand(sql, _dbConn);
                SqlCommand cmd = new SqlCommand(sql, _dbConn);
                _cmd.Parameters.AddWithValue("@Name", c.Name);
                _cmd.Parameters.AddWithValue("@Email", c.Email);
                _cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                    
                throw new Exception("Erro ao inserir Cliente" + ex.Message);
            }
        }

        public void Open()
        {
            try
            {
                _dbConn.Open();
            }
            catch (Exception)
            {
                // Gerar log se necessário
                throw;
            }
        }

        public void CloseConnection()
        {
            _dbConn.Close();
        }

        public List<Client> List()
        {
            string sql = "select * from client order by name";
            _cmd = new SqlCommand(sql, _dbConn);
            _dr = _cmd.ExecuteReader();

            List<Client> list = new List<Client>();

            while (_dr.Read())
            {
                Client c = new Client();
                c.Name = _dr["Name"].ToString();
                c.Email = _dr["Email"].ToString();
                list.Add(c);
            }

            return list;
        }
    }

    
}
