using OnlineStore.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Services
{
    public interface IProductService
    {
        Task<Product> FindByIdAsync(int id);
        Task<IEnumerable<Product>> FindByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Product>> ListAsync();
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> AddAsync(Product product);
      
        Task<Product> Remove(int id);
    }
}
