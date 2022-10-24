using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain;
using OnlineStore.Domain.Repositories;
using OnlineStore.Infrastructure.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task<Product> FindByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync( p=>p.Id==id);
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
