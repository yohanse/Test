using Application.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly CineFlexDbContext _dbContext;
        public BookRepository(CineFlexDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        Task<IReadOnlyList<BookDto>> Search(string title) {
            Var query = _dbContext.Set<T>();

            if (!string.IsNullOrEmpty(searchTitle))
                {
                    query = query.Where(entity => entity.Title.Contains(searchTitle));
                }

            return await query.ToListAsync();
        }

    }
}
