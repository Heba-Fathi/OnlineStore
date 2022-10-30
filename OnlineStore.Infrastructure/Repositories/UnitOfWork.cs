using OnlineStore.Domain.Repositories;
using OnlineStore.Infrastructure.Contexts;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

       

        public async Task CompleteAsync()
        {

            await _context.SaveChangesAsync();


        }
    }
}
