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
    public class MovieRepository : IMovieRepository
    {
        private string _connectionString;
        private DbProviderFactory _dbProviderFactory
        {
            get { return SqlClientFactory.Instance; }
        }

        public MovieRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Default");
        }

        public Movie Converter(IDataRecord reader)
        {
            return new Movie
            {
                Id = (int)reader["Id"],
                Title = reader["Title"].ToString(),
                Synopsis = reader["Synopsis"].ToString(),
                ReleaseYear = (int)reader["ReleaseYear"],
                RealisatorId = (int)reader["RealisatorId"],
                ScenaristId = (int)reader["ScenaristId"]
            };
        }

        public void Create(Movie m)
        {
            Command cmd = new Command("MovieCreate", true);
            cmd.AddParameter("Title", m.Title);
            cmd.AddParameter("Synopsis", m.Synopsis);
            cmd.AddParameter("ReleaseYear", m.ReleaseYear);
            cmd.AddParameter("RealisatorId", m.RealisatorId);
            cmd.AddParameter("ScenaristId", m.ScenaristId);

            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            cnx.ExecuteNonQuery(cmd);
        }

        public IEnumerable<Movie> GetAll()
        {
            Command cmd = new Command("SELECT * FROM Movie");
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter);
        }

        public Movie GetById(int Id)
        {
            Command cmd = new Command("SELECT * FROM Movie WHERE Id = @Id");
            cmd.AddParameter("Id", Id);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter).FirstOrDefault();
        }

        public IEnumerable<Casting> GetCastingByMovieId(int MovieId)
        {
            Command cmd = new Command("SELECT * FROM Casting WHERE MovieId = @MovieId");
            cmd.AddParameter("MovieId", MovieId);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, (IDataReader r) =>
            {
                return new Casting
                {
                    Id = (int)r["Id"],
                    MovieId = (int)r["MovieId"],
                    PersonId = (int)r["PersonId"],
                    Role = r["Role"].ToString()
                };
            });
        }
    }
}
