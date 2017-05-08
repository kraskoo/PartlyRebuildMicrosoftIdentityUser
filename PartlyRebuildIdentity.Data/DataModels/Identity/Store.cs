namespace PartlyRebuildIdentity.Data.DataModels.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Intefaces.IdentityStores;
    using Models.Identity;

    public abstract class Store<TUser, TRole, TKey, TUserLogin, TUserRole, TUserClaim> :
        IIdentityLoginStore<TUser, TKey>,
        IIdentityClaimStore<TUser, TKey>,
        IIdentityRoleStore<TUser, TKey>,
        IIdentityPasswordStore<TUser, TKey>,
        IIdentitySecurityStampStore<TUser, TKey>,
        IQueryableIdentityStore<TUser, TKey>,
        IIdentityEmailStore<TUser, TKey>,
        IIdentityPhoneNumberStore<TUser, TKey>,
        IIdentityTwoFactorStore<TUser, TKey>,
        IIdentityLockoutStore<TUser, TKey>
        where TUser : IdentityApplicationUser<TKey>, IUser<TKey>
        where TRole : Role<TKey>
        where TKey : IEquatable<TKey>
        where TUserLogin : Login<TKey>, new()
        where TUserRole : IdentityUserRoleInner<TKey>, new()
        where TUserClaim : Claim<TKey>, new()
    {
        protected Store(IQueryable<TUser> users)
        {
            this.Users = users;
        }

        public IQueryable<TUser> Users { get; }

        public abstract void Dispose();

        public abstract Task CreateAsync(TUser user);

        public abstract Task UpdateAsync(TUser user);

        public abstract Task DeleteAsync(TUser user);

        public abstract Task<TUser> FindByIdAsync(TKey userId);

        public abstract Task<TUser> FindByNameAsync(string userName);

        public abstract Task AddLoginAsync(TUser user, UserLoginInfo login);

        public abstract Task RemoveLoginAsync(TUser user, UserLoginInfo login);

        public abstract Task<IList<UserLoginInfo>> GetLoginsAsync(TUser user);

        public abstract Task<TUser> FindAsync(UserLoginInfo login);

        public abstract Task<IList<Claim>> GetClaimsAsync(TUser user);

        public abstract Task AddClaimAsync(TUser user, Claim claim);

        public abstract Task RemoveClaimAsync(TUser user, Claim claim);

        public abstract Task AddToRoleAsync(TUser user, string roleName);

        public abstract Task RemoveFromRoleAsync(TUser user, string roleName);

        public abstract Task<IList<string>> GetRolesAsync(TUser user);

        public abstract Task<bool> IsInRoleAsync(TUser user, string roleName);

        public abstract Task SetPasswordHashAsync(TUser user, string passwordHash);

        public abstract Task<string> GetPasswordHashAsync(TUser user);

        public abstract Task<bool> HasPasswordAsync(TUser user);

        public abstract Task SetSecurityStampAsync(TUser user, string stamp);

        public abstract Task<string> GetSecurityStampAsync(TUser user);

        public abstract Task SetEmailAsync(TUser user, string email);

        public abstract Task<string> GetEmailAsync(TUser user);

        public abstract Task<bool> GetEmailConfirmedAsync(TUser user);

        public abstract Task SetEmailConfirmedAsync(TUser user, bool confirmed);

        public abstract Task<TUser> FindByEmailAsync(string email);

        public abstract Task SetPhoneNumberAsync(TUser user, string phoneNumber);

        public abstract Task<string> GetPhoneNumberAsync(TUser user);

        public abstract Task<bool> GetPhoneNumberConfirmedAsync(TUser user);

        public abstract Task SetPhoneNumberConfirmedAsync(TUser user, bool confirmed);

        public abstract Task SetTwoFactorEnabledAsync(TUser user, bool enabled);

        public abstract Task<bool> GetTwoFactorEnabledAsync(TUser user);

        public abstract Task<DateTimeOffset> GetLockoutEndDateAsync(TUser user);

        public abstract Task SetLockoutEndDateAsync(TUser user, DateTimeOffset lockoutEnd);

        public abstract Task<int> IncrementAccessFailedCountAsync(TUser user);

        public abstract Task ResetAccessFailedCountAsync(TUser user);

        public abstract Task<int> GetAccessFailedCountAsync(TUser user);

        public abstract Task<bool> GetLockoutEnabledAsync(TUser user);

        public abstract Task SetLockoutEnabledAsync(TUser user, bool enabled);
    }
}