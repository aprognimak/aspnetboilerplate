using System;
using Abp.Dependency;
using Abp.Extensions;
using Abp.MultiTenancy;
using Microsoft.AspNetCore.Http;

namespace Abp.AspNetCore.MultiTenancy
{
    public class HttpCookieTenantResolveContributor : ITenantResolveContributor, ITransientDependency
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpCookieTenantResolveContributor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid? ResolveTenantId()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                return null;
            }

            var tenantIdValue = httpContext.Request.Cookies[MultiTenancyConsts.TenantIdResolveKey];
            if (tenantIdValue.IsNullOrEmpty())
            {
                return null;
            }

            Guid tenantId;
            return !Guid.TryParse(tenantIdValue, out tenantId) ? (Guid?) null : tenantId;
        }
    }
}