using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Seal.Backend.DAL.Base;
using Seal.Common.Domain.DataContext;
using Seal.Common.Domain.Models.Hop;
using Seal.Common.Infrastructure.Repository;
using Seal.Common.ViewModel.Hop;
using Seal.Common.ViewModel.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seal.Backend.DAL.TemplateRepository
{
    public class HopRepository : BaseRepository<IApplicationDbContext>, IHopRepository
    {
        public HopRepository( IApplicationDbContext context) : base(context)
        {
           
        }

        public async Task<T> GetHopAsync<T>(int id) where T : class, IViewModel<int>
        {
            var result = await Context.Hops.Where(x => x.Id == id).ProjectTo<T>().FirstAsync();
            return result;
        }

        public T GetHop<T>(int id) where T : class, IViewModel<int>
        {
            Hop hop =  Context.Hops.FirstOrDefault();

            var result =  AutoMapper.Mapper.Map<T>(hop);

            return result;
        }

        public async Task AddHopAsync<T>(T hop) where T : IViewModel<int>
        {
            var insert = AutoMapper.Mapper.Map<Hop>(hop);

            await Context.Hops.AddAsync(insert);

            //Context.SaveChanges();
        }

    }
}
