using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Works30.Models
{
    public class Product
    {
       public long Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        
        public int UnitsInStock { get; set; }
    
    
    }
}
