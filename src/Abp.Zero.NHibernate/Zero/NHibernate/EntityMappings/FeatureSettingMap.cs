using System;
using Abp.Application.Features;
using Abp.NHibernate.EntityMappings;

namespace Abp.Zero.NHibernate.EntityMappings
{
    public class FeatureSettingMap : EntityMap<FeatureSetting, Guid>
    {
        public FeatureSettingMap()
            : base("AbpFeatures")
        {
            DiscriminateSubClassesOnColumn("Discriminator");

            Map(x => x.Name);
            Map(x => x.Value);
            
            this.MapCreationAudited();
        }
    }
}