using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace ApphbMvcLabs.Data.Entities
{
    public class User : IUser<Guid>
    {
        public User()
        {
            Id = Guid.NewGuid();
        }

        public User(string userName)
            : this()
        {
            UserName = userName;
        }

        public Guid Id { get; set; }
        public virtual string PasswordHash { get; set; }
        public virtual string SecurityStamp { get; set; }
        public string UserName { get; set; }
    }
}