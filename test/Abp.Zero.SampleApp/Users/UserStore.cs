using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Zero.SampleApp.Roles;

namespace Abp.Zero.SampleApp.Users
{
    public class UserStore : AbpUserStore<Role, User>
    {
        public UserStore(
            IRepository<User> userRepository,
            IRepository<UserLogin> userLoginRepository,
            IRepository<UserRole> userRoleRepository,
            IRepository<Role> roleRepository,
            IRepository<UserPermissionSetting> userPermissionSettingRepository,
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<UserClaim> userClaimRepository)
            : base(
                userRepository,
                userLoginRepository,
                userRoleRepository,
                roleRepository,
                userPermissionSettingRepository,
                unitOfWorkManager,
                userClaimRepository)
        {

        }
    }
}