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
using AutoMapper;
using Seal.Common.ViewModel.Interaces;
using Seal.Common.ViewModel.Template;
using AutoMapper.QueryableExtensions;

namespace Seal.Backend.DAL.TemplateRepository
{
    public class TemplateRepository : BaseRepository<IApplicationDbContext>, ITemplateRepository 
    {
        public TemplateRepository(IApplicationDbContext context) : base(context)
        {

        }

        public int GetFoo()
        {
            var chartDefinitions = Context.MainTemplate.Where(x => x.Id == 4).ProjectTo<TemplateViewModel>().ToList();

            return 123;
        }

        public async Task<T> GetFooAsync<T>(int id) where T : class, IViewModel<int>
        {
            var result = await Context.MainTemplate.Where(x => x.Id == id).ProjectTo<T>().FirstAsync();
            return result;
        }

        public async Task<List<T>> GetTemplatesAsync<T>(int id) where T : class, IViewModel<int>
        {
            var a = await Context.MainTemplate.ProjectTo<T>().Where(x => x.Id >= 3).ProjectTo<T>().ToListAsync();
           
            return a;
        }
    }
}
