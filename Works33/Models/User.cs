using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Works33.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
