using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApphbMvcLabs.Data.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}