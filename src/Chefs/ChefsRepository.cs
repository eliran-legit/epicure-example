using API.src.Entity;
using Microsoft.EntityFrameworkCore;
using src.Database;

namespace src.Chefs
{
    public class ChefsRepository
    {
        private readonly AppDbContext _appDbContext;


        public ChefsRepository(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }

        public async Task<List<Chef>> GetAllChefs()
        {
            return await _appDbContext.Chef.ToListAsync();
        }

        public IQueryable<Chef> GetChefById(int id){
            return _appDbContext.Chef.Where(_=> _.Id == id);
        }
    }
}