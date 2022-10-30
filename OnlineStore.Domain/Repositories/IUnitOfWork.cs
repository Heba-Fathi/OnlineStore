using System.Threading.Tasks;

namespace OnlineStore.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
