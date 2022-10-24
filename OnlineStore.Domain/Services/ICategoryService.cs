using System.Threading.Tasks;

namespace OnlineStore.Domain.Services
{
    interface ICategoryService
    {
        Task<Category> FindByIdAsync(int id);
        Task<Category> ListAsync(Category category);
        Task<Category> UpdateAsync(int id, Category category);
        Task<Category> AddAsync(Category category);

        Task<Category> Remove(int id);
    }
}
