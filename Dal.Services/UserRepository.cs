using ADOLibrary;
using Dal.Entities;
using Dal.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Services
{
    public class UserRepository : IUserRepository
    {
        private string _connectionString;
        private DbProviderFactory _dbProviderFactory
        {
            get { return SqlClientFactory.Instance; }
        }

        public UserRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Default");
        }

        public User Converter(IDataRecord reader)
        {
            return new User
            {
                Id = (int)reader["Id"],
                LastName = reader["LastName"].ToString(),
                FirstName = reader["FirstName"].ToString(),
                IsAdmin = (bool)reader["IsAdmin"]
            };
        }

        public void Register(User u)
        {
            Command cmd = new Command("UserCreate", true);
            cmd.AddParameter("LastName", u.LastName);
            cmd.AddParameter("FirstName", u.FirstName);
            cmd.AddParameter("Password", u.Password);
            cmd.AddParameter("Email", u.Email);

            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            cnx.ExecuteNonQuery(cmd);
        }

        public User Login(string email, string password)
        {
            Command cmd = new Command("UserLogin", true);
            cmd.AddParameter("Email", email);
            cmd.AddParameter("Password", password);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader<User>(cmd, Converter).FirstOrDefault();
        }
    }
}
