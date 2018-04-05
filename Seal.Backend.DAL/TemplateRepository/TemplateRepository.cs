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

namespace Seal.Backend.DAL.TemplateRepository
{
    public class TemplateRepository : BaseRepository<IApplicationDbContext>, ITemplateRepository 
    {
        public TemplateRepository(IApplicationDbContext context) : base(context)
        {

        }

        public int GetFoo()
        {
            var chartDefinitions = Context.MainTemplate.Where(x => x.Id == 4).FirstOrDefault();
           
            return 123;
        }

        //public async Task<> GetFooAsunc<T>(int id) where T : MainTemplate
        //public async Task<MainTemplate> GetFooAsunc(int id) 
        //{
        //    var result = await Context.MainTemplate.Where(x => x.Id == 4);
        //    return result;
        //}

        public async Task<MainTemplate> GetTemplatesAsync(int id) 
        {
            var chartDefinitions = await Context.MainTemplate.FirstAsync(x => x.Id >= 3);
           
            return chartDefinitions;
        }
    }
}
