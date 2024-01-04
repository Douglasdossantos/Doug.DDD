﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doug.Domain.Interfaces.Repository
{
    public interface IUnitOfWork<TContext>
    {
        Task CommitAsync();
    }
}
