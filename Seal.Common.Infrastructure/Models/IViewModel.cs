namespace Seal.Common.Infrastructure.Models
{
    public interface IViewModel<T>
    {
        T Id { get; set; }
    }
}
