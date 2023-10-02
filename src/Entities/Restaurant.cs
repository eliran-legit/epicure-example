using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.src.Entity;

namespace src.Entity
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Chef Chef { get; set; }
        public int Rating { get; set; }

        public string Image { get; set; }
        
    }
}