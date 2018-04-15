using System;
using System.Collections.Generic;
using System.Text;

namespace Seal.Common.Domain.Models.Hop
{
    public class Hop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IbuLevel { get; set; }
        public string Description { get; set; }
        public int Cantry { get; set; }
        public DateTime Packed { get; set; }
    }
}
