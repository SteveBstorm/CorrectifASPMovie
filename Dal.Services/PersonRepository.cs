using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using ADOLibrary;
using Dal.Interface;

namespace Dal.Services
{
    public class PersonRepository : IPersonRepository
    {
        private string _connectionString;
        private DbProviderFactory _dbProviderFactory
        {
            get { return SqlClientFactory.Instance; }
        }

        public PersonRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Default");
        }

        public Person Converter(IDataRecord reader)
        {
            return new Person
            {
                Id = (int)reader["Id"],
                LastName = reader["LastName"].ToString(),
                FirstName = reader["FirstName"].ToString()
            };
        }

        public void Create(Person p)
        {
            Command cmd = new Command("INSERT INTO Person VALUES(@FirstName, @LastName)");
            cmd.AddParameter("FirstName", p.FirstName);
            cmd.AddParameter("LastName", p.LastName);

            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            cnx.ExecuteNonQuery(cmd);
        }

        public IEnumerable<Person> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Person");
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter);
        }

        public Person GetById(int Id)
        {
            Command cmd = new Command("SELECT * FROM Person WHERE Id = @Id");
            cmd.AddParameter("Id", Id);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public Person GetRealistorByMovieId(int MovieId)
        {
            Command cmd = new Command("SELECT p.Id, p.LastName, p.FirstName " +
                "FROM Person p JOIN Movie m ON p.Id = m.RealisatorId WHERE m.Id = @Id");
            cmd.AddParameter("Id", MovieId);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public Person GetScenaristByMovieId(int MovieId)
        {
            Command cmd = new Command("SELECT p.Id, p.LastName, p.FirstName " +
                "FROM Person p JOIN Movie m ON p.Id = m.ScenaristId WHERE m.Id = @Id");
            cmd.AddParameter("Id", MovieId);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public void SetRole(int MovieId, int PersonId, string Role)
        {
            Command cmd = new Command("INSERT INTO Casting VALUES (@MovieId, @PersonId, @Role)");
            cmd.AddParameter("MovieId", MovieId);
            cmd.AddParameter("PersonId", PersonId);
            cmd.AddParameter("Role", Role);

            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            cnx.ExecuteNonQuery(cmd);
        }
    }
}
