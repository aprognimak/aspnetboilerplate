using System;
using Abp.Authorization;
using Abp.NHibernate.EntityMappings;

namespace Abp.Zero.NHibernate.EntityMappings
{
    public class PermissionSettingMap : EntityMap<PermissionSetting, Guid>
    {
        public PermissionSettingMap()
            : base("AbpPermissions")
        {
            DiscriminateSubClassesOnColumn("Discriminator");

            Map(x => x.Name);
            Map(x => x.IsGranted);

            this.MapCreationAudited();
        }
    }
}