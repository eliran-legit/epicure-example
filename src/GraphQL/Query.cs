using API.src.Entity;
using Microsoft.EntityFrameworkCore;
using src.Chefs;

namespace API.src.Graph
{
    public class Query
    {
        public Task<Chef> GetChefById([Service] ChefsRepository chefRepository, int chefId)
        {
            return chefRepository.GetChefById(chefId).FirstOrDefaultAsync();
        }

        public async Task<List<Chef>> GetAllChefs([Service] ChefsRepository chefsRepository)
        {
            return await chefsRepository.GetAllChefs();
        }
    }
}