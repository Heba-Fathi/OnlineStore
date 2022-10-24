using System.Threading.Tasks;

namespace OnlineStore.Domain.Services
{
    interface IProductService
    {
        Task<Product> FindByIdAsync(int id);
        Task<Product> ListAsync(Product product);
        Task<Product> UpdateAsync(int id, Product product);
        Task<Product> AddAsync(Product product);
      
        Task<Product> Remove(int id);
    }
}
