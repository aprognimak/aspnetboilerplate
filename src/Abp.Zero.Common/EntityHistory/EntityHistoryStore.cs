﻿using System;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Domain.Repositories;

namespace Abp.EntityHistory
{
    /// <summary>
    /// Implements <see cref="IEntityHistoryStore"/> to save entity change informations to database.
    /// </summary>
    public class EntityHistoryStore : IEntityHistoryStore, ITransientDependency
    {
        private readonly IRepository<EntityChangeSet, Guid> _changeSetRepository;

        /// <summary>
        /// Creates a new <see cref="EntityHistoryStore"/>.
        /// </summary>
        public EntityHistoryStore(IRepository<EntityChangeSet, Guid> changeSetRepository)
        {
            _changeSetRepository = changeSetRepository;
        }

        public virtual Task SaveAsync(EntityChangeSet changeSet)
        {
            return _changeSetRepository.InsertAsync(changeSet);
        }
    }
}
