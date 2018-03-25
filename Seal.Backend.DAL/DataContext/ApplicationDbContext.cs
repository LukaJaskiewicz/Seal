using Microsoft.EntityFrameworkCore;
using Seal.Common.Domain.DataContext;
using Seal.Common.Domain.Models.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Backend.DAL.DataContext
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<MainTemplate> MainTemplate { get; set; }
        public DbSet<RelatedTemplate> RelatedTemplate { get; set; }
    }
}
