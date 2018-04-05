using Microsoft.EntityFrameworkCore;
using Seal.Common.Domain.Models.Hop;
using Seal.Common.Domain.Models.Template;

namespace Seal.Common.Domain.DataContext
{
    public interface IApplicationDbContext
    {
        DbSet<MainTemplate> MainTemplate { get; set; }
        DbSet<RelatedTemplate> RelatedTemplate { get; set; }

        DbSet<Hop> Hops { get; set; }
    }
}
