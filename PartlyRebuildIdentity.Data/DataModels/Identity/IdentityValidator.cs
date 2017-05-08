namespace PartlyRebuildIdentity.Data.DataModels.Identity
{
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;

    public class IdentityValidator : IIdentityValidator<ApplicationUser>
    {
        public IdentityValidator(DataUserManager manager)
        {
            this.UserManager = manager;
        }

        public DataUserManager UserManager { get; }

        public async Task<IdentityResult> ValidateAsync(ApplicationUser item)
        {
            return await new Task<IdentityResult>(
                () => this.UserManager.AccessFailed(item.Id));
        }
    }
}