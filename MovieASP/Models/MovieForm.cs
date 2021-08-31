using Dal.Entities;
using Dal.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieASP.Models
{
    public class MovieForm
    {
        private IPersonRepository _personService;

        public MovieForm(IPersonRepository ps)
        {
            _personService = ps;
        }

        public MovieForm()
        {

        }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Synopsis { get; set; }
        
        public int ReleaseYear { get; set; }
        [Required]
        [HiddenInput]
        public int RealisatorId { get; set; }

        public IEnumerable<Person> Real
            { 
                get 
                { 
                    return _personService is null ? null : _personService.GetAll(); 
                }
            }
        
        [Required]
        [HiddenInput]
        public int ScenaristId { get; set; }

        public IEnumerable<Person> Scen
        {
            get
            {
                return _personService is null ? null : _personService.GetAll();
            }
        }

    }
}
