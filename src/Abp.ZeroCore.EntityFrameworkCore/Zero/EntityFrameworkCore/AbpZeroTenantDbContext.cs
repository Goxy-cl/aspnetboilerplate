using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Abp.Organizations;
using Microsoft.EntityFrameworkCore;

namespace Abp.Zero.EntityFrameworkCore
{
    [MultiTenancySide(MultiTenancySides.Host)]
    public abstract class AbpZeroTenantDbContext<TRole, TUser, TUserRole, TOrganizationUnit, TSelf> : AbpZeroCommonDbContext<TRole, TUser, TUserRole, TOrganizationUnit, TSelf>
        where TRole : AbpRole<TUser>
        where TUser : AbpUser<TUser>
        where TUserRole : UserRole
        where TOrganizationUnit : OrganizationUnit
        where TSelf : AbpZeroTenantDbContext<TRole, TUser, TUserRole, TOrganizationUnit, TSelf>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        protected AbpZeroTenantDbContext(DbContextOptions<TSelf> options)
            :base(options)
        {

        }
    }
}