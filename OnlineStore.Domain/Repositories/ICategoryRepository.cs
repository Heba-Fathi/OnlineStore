using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<Category> FindByIdAsync(int id);
        Task AddAsync(Category category);
        void Update(Category category);
        void Remove(Category category);
    }
}
