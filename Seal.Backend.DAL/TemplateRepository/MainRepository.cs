using Seal.Backend.DAL.Base;
using Seal.Common.Domain.DataContext;
using Seal.Common.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Backend.DAL.TemplateRepository
{
 

        public class MainRepository : BaseRepository<IApplicationDbContext>
        {
            public MainRepository(IApplicationDbContext context) : base(context)
            {

            }

            public int GetFoo()
            {
                return 666;
            }

        }
}
