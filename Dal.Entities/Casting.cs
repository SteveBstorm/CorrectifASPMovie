﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities
{
    public class Casting
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int PersonId { get; set; }
        public string Role { get; set; }
    }
}
