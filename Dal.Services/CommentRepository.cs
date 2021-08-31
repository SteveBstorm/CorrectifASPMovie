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
    public class CommentRepository : ICommentRepository
    {
        private string _connectionString;
        private DbProviderFactory _dbProviderFactory
        {
            get { return SqlClientFactory.Instance; }
        }

        public CommentRepository(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Default");
        }

        public Comment Converter(IDataRecord reader)
        {
            return new Comment
            {
                Id = (int)reader["Id"],
                Content = reader["Content"].ToString(),
                UserId = (int)reader["UserId"],
                MovieId = (int)reader["MovieId"]
            };
        }

        public void Create(Comment c)
        {
            Command cmd = new Command("INSERT INTO Comments VALUES (@Content, @UserId, @MovieId)");
            cmd.AddParameter("Content", c.Content);
            cmd.AddParameter("UserId", c.UserId);
            cmd.AddParameter("MovieId", c.MovieId);

            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            cnx.ExecuteNonQuery(cmd);
        }

        public IEnumerable<Comment> GetByMovieId(int MovieId)
        {
            Command cmd = new Command("SELECT * FROM Comments WHERE MovieId = @MovieId");
            cmd.AddParameter("MovieId", MovieId);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            return cnx.ExecuteReader(cmd, Converter);
        }

        public void Delete(int Id)
        {
            Command cmd = new Command("DELETE FROM Comments WHERE Id = @Id");
            cmd.AddParameter("Id", Id);
            Connection cnx = new Connection(_dbProviderFactory, _connectionString);
            cnx.ExecuteNonQuery(cmd);
        }
    }
}
