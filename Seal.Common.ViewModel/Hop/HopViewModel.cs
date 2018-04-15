using Seal.Common.ViewModel.Interaces;
using System;

namespace Seal.Common.ViewModel.Hop
{
    public class HopViewModel : IViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int  Cantry { get; set; }
        public DateTime Packed { get; set; }
       
    }
}
