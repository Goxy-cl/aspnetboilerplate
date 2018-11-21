using System.Collections.Generic;
using Abp.Threading;

namespace Abp.Organizations
{
    public static class OrganizationUnitManagerExtensions
    {
        public static string GetCode<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, long id)
            where TOrganizationUnit : OrganizationUnit
        {
            return AsyncHelper.RunSync(() => manager.GetCodeAsync(id));
        }

        public static void Create<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, TOrganizationUnit organizationUnit)
            where TOrganizationUnit : OrganizationUnit
        {
            AsyncHelper.RunSync(() => manager.CreateAsync(organizationUnit));
        }

        public static void Update<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, TOrganizationUnit organizationUnit)
            where TOrganizationUnit : OrganizationUnit
        {
            AsyncHelper.RunSync(() => manager.UpdateAsync(organizationUnit));
        }

        public static void Delete<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, long id)
            where TOrganizationUnit : OrganizationUnit
        {
            AsyncHelper.RunSync(() => manager.DeleteAsync(id));
        }

        public static string GetNextChildCode<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, long? parentId)
            where TOrganizationUnit : OrganizationUnit
        {
            return AsyncHelper.RunSync(() => manager.GetNextChildCodeAsync(parentId));
        }

        public static TOrganizationUnit GetLastChildOrNull<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, long? parentId)
            where TOrganizationUnit : OrganizationUnit
        {
            return AsyncHelper.RunSync(() => manager.GetLastChildOrNullAsync(parentId));
        }

        public static void Move<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, long id, long? parentId)
            where TOrganizationUnit : OrganizationUnit
        {
            AsyncHelper.RunSync(() => manager.MoveAsync(id, parentId));
        }

        public static List<TOrganizationUnit> FindChildren<TOrganizationUnit>(this OrganizationUnitManager<TOrganizationUnit> manager, long? parentId, bool recursive = false)
            where TOrganizationUnit : OrganizationUnit
        {
            return AsyncHelper.RunSync(() => manager.FindChildrenAsync(parentId, recursive));
        }
    }
}