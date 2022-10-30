using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<IEnumerable<Product>> FindByCategoryIdAsync(int categoryId);
        Task<Product> FindByIdAsync(int id);
        Task AddAsync(Product product);
        void Update(Product product);
        void Remove(Product product);
    }
}
