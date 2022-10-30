using OnlineStore.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Services
{
    public interface ICategoryService
    {
        Task<Category> FindByIdAsync(int id);
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> AddAsync(Category category);

        Task<Category> Remove(int id);
    }
}
