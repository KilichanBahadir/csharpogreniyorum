using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Works34.Core.Entities;

namespace Works34.Entities
{
    public class Contact : IEntity
    {
        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
