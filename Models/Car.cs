using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autoclean.Models
{
    public class Car
    {
         public int Id { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        
        public decimal Price { get; set; }
    }
}