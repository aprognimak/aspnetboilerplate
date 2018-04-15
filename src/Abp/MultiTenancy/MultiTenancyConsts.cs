using System;

namespace Abp.MultiTenancy
{
    public static class MultiTenancyConsts
    {
        /// <summary>
        /// Default tenant id: 1.
        /// </summary>
        public static Guid DefaultTenantId = Guid.Empty;

        public const string TenantIdResolveKey = "Abp.TenantId";
    }
}