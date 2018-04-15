using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Backend.DAL.Base
{
    public abstract class BaseRepository<T> 
    {
        protected readonly T Context;

        protected BaseRepository(T context)
        {
            Context = context;
        }
    }
}
