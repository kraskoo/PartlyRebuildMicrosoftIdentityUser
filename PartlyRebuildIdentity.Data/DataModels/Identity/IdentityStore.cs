namespace PartlyRebuildIdentity.Data.DataModels.Identity
{
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;

    public class IdentityStore : IUserStore<ApplicationUser, Guid>
    {
        private Context context;
        private bool isDisposed;

        public IdentityStore(Context context)
        {
            this.context = context;
            this.isDisposed = false;
        }

        public async Task CreateAsync(ApplicationUser user)
        {
            await Task.Run(() =>
            {
                this.context.Users.Add(user);
            });
        }

        public async Task UpdateAsync(ApplicationUser user)
        {
            await Task.Run(() =>
            {
                this.context.Users.Attach(user);
                this.context.Entry(user).State = EntityState.Modified;
            });
        }

        public async Task DeleteAsync(ApplicationUser user)
        {
            await Task.Run(() =>
            {
                this.context.Users.Remove(user);
            });
        }

        public async Task<ApplicationUser> FindByIdAsync(Guid userId)
        {
            return (ApplicationUser) await Task.Run(() => this.context.Users.Find(userId));
        }

        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            return await Task.Run(() => this.context.Users.Find(userName));
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                this.isDisposed = true;
                this.context.Dispose();
                this.context = null;
                GC.SuppressFinalize(this);
            }
            else
            {
                throw new ArgumentNullException(
                    nameof(IdentityStore), @"The object cannot be disposed twice.");
            }
        }
    }
}