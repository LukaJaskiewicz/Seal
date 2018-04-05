using Seal.Common.Infrastructure.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seal.Common.Domain.Models.Template
{
    public class MainTemplate : IDomain
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string AdditionalDescription { get; set; }

        public List<RelatedTemplate> RelatedTemplates { get; set; } = new List<RelatedTemplate>();
    }
}
