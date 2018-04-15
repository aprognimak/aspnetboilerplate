using System;
using System.Web;
using Abp.Dependency;
using Abp.Extensions;
using Abp.MultiTenancy;

namespace Abp.Web.MultiTenancy
{
    public class HttpCookieTenantResolveContributor : ITenantResolveContributor, ITransientDependency
    {
        public Guid? ResolveTenantId()
        {
            var cookie = HttpContext.Current?.Request.Cookies[MultiTenancyConsts.TenantIdResolveKey];
            if (cookie == null || cookie.Value.IsNullOrEmpty())
            {
                return null;
            }

            Guid tenantId;
            return !Guid.TryParse(cookie.Value, out tenantId) ? (Guid?) null : tenantId;
        }
    }
}