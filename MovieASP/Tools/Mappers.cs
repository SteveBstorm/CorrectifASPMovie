using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL = Dal.Entities;
using ASP = MovieASP.Models;

namespace MovieASP.Tools
{
    public static class Mappers
    {
        public static DAL.User ToDal(this ASP.UserForm u)
        {
            return new DAL.User
            {
                Email = u.Email,
                Password = u.Password,
                FirstName = u.FirstName,
                LastName = u.LastName
            };
        }

        public static ASP.User ToDal(this DAL.User u)
        {
            return new ASP.User
            {
                Email = u.Email,
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                IsAdmin = u.IsAdmin
            };
        }

        public static DAL.Movie ToDal(this ASP.MovieForm m)
        {
            return new DAL.Movie
            {
                Title = m.Title,
                ReleaseYear = m.ReleaseYear,
                RealisatorId = m.RealisatorId,
                ScenaristId = m.ScenaristId,
                Synopsis = m.Synopsis
            };
        }

        public static DAL.Person ToDal(this ASP.PersonForm p)
        {
            return new DAL.Person
            {
                LastName = p.LastName,
                FirstName = p.FirstName
            };
        }

        public static DAL.Casting ToDal(this ASP.CastingForm c)
        {
            return new DAL.Casting
            {
                MovieId = c.MovieId,
                PersonId = c.PersonId,
                Role = c.Role

            };
        }
    }
}
