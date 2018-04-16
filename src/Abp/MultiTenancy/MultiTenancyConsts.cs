using System;

namespace Abp.MultiTenancy
{
    public static class MultiTenancyConsts
    {
        /// <summary>
        /// Default tenant id: 1.
        /// </summary>
        public static Guid DefaultTenantId = Guid.Parse("00000000-0000-0000-0000-000000000001");

        public const string TenantIdResolveKey = "Abp.TenantId";
    }
}