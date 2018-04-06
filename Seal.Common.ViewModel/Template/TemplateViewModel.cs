

using Seal.Common.ViewModel.Interaces;

namespace Seal.Common.ViewModel.Template
{
    public class TemplateViewModel : IViewModel<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Desc { get; set; }
    }
}
