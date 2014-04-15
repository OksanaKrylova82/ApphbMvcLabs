using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ApphbMvcLabs.Data;
using ApphbMvcLabs.Data.Entities;
using Microsoft.AspNet.Identity;

namespace ApphbMvcLabs.Code.Identity
{
    public class UserStore : IUserPasswordStore<User, Guid>, IUserSecurityStampStore<User, Guid>
    {
        protected Microsoft.AspNet.Identity.EntityFramework.UserStore<Microsoft.AspNet.Identity.EntityFramework.IdentityUser> userStore =
            new Microsoft.AspNet.Identity.EntityFramework.UserStore<Microsoft.AspNet.Identity.EntityFramework.IdentityUser>(new DataContext());

        public Task CreateAsync(User user)
        {
            var context = userStore.Context as DataContext;
            context.Users.Add(user);
            context.Configuration.ValidateOnSaveEnabled = false;
            return context.SaveChangesAsync();
        }

        public Task DeleteAsync(User user)
        {
            var context = userStore.Context as DataContext;
            context.Users.Remove(user);
            context.Configuration.ValidateOnSaveEnabled = false;
            return context.SaveChangesAsync();
        }

        public Task<User> FindByIdAsync(Guid userId)
        {
            var context = userStore.Context as DataContext;
            return context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public Task<User> FindByNameAsync(string userName)
        {
            var context = userStore.Context as DataContext;
            return context.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
        }

        public Task UpdateAsync(User user)
        {
            var context = userStore.Context as DataContext;
            context.Users.Attach(user);
            context.Entry(user).State = EntityState.Modified;
            context.Configuration.ValidateOnSaveEnabled = false;
            return context.SaveChangesAsync();
        }

        public void Dispose()
        {
            userStore.Dispose();
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            var identityUser = ToIdentityUser(user);
            var task = userStore.GetPasswordHashAsync(identityUser);
            SetUser(user, identityUser);
            return task;
        }

        public Task<bool> HasPasswordAsync(User user)
        {
            var identityUser = ToIdentityUser(user);
            var task = userStore.HasPasswordAsync(identityUser);
            SetUser(user, identityUser);
            return task;
        }

        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            var identityUser = ToIdentityUser(user);
            var task = userStore.SetPasswordHashAsync(identityUser, passwordHash);
            SetUser(user, identityUser);
            return task;
        }

        public Task<string> GetSecurityStampAsync(User user)
        {
            var identityUser = ToIdentityUser(user);
            var task = userStore.GetSecurityStampAsync(identityUser);
            SetUser(user, identityUser);
            return task;
        }

        public Task SetSecurityStampAsync(User user, string stamp)
        {
            var identityUser = ToIdentityUser(user);
            var task = userStore.SetSecurityStampAsync(identityUser, stamp);
            SetUser(user, identityUser);
            return task;
        }

        private static void SetUser(User user, Microsoft.AspNet.Identity.EntityFramework.IdentityUser identityUser)
        {
            user.PasswordHash = identityUser.PasswordHash;
            user.SecurityStamp = identityUser.SecurityStamp;
        }

        private static Microsoft.AspNet.Identity.EntityFramework.IdentityUser ToIdentityUser(User user)
        {
            return new Microsoft.AspNet.Identity.EntityFramework.IdentityUser
            {
                PasswordHash = user.PasswordHash,
                SecurityStamp = user.SecurityStamp,
                UserName = user.UserName
            };
        }
    }
}