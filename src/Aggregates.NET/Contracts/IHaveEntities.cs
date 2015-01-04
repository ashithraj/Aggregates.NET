﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.Contracts
{
    public interface IHaveEntities
    {
        IEntityRepository<T> E<T>() where T : class, IEntity;
        IEntityRepository<T> Entity<T>() where T : class, IEntity;
    }
}
