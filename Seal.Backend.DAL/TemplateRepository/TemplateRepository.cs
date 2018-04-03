using Microsoft.EntityFrameworkCore;
using Seal.Backend.DAL.Base;
using Seal.Common.Domain.DataContext;
using Seal.Common.Domain.Models.Template;
using Seal.Common.Infrastructure.Models;
using Seal.Common.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Backend.DAL.TemplateRepository
{
    public class TemplateRepository : BaseRepository<IApplicationDbContext>, ITemplateRepository 
    {
        public TemplateRepository(IApplicationDbContext context) : base(context)
        {

        }

        public int GetFoo()
        {
            return 123;
        }

        //  public async Task<IEnumerable<T>> GetTemplatesAsync<T>(int id) where T : MainTemplate
        //public async Task<IEnumerable<T>> GetTemplatesAsync<T>(int id) where T : MainTemplate
        //{
        //    var chartDefinitions = await Context.MainTemplate.ToListAsync<T>().ContinueWith<IList<MainTemplate>>(t => t, TaskContinuationOptions.ExecuteSynchronously); ;


        //    return chartDefinitions;
        //}
    }
}
