using LAtelier.CutestCatApi.Domain.Entities;
using LAtelier.CutestCatApi.Domain.Interfaces;
using LAtelier.CutestCatApi.Infrastructure.SQLiteDb;

namespace LAtelier.CutestCatApi.Infrastructure.Repositories
{
    public class CatsRepository : ICatsRepository
    {
        /// <summary>
        /// the db context
        /// </summary>
        private readonly DataContext _context;

        public CatsRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all cats available
        /// </summary>
        /// <returns></returns>
        public List<CatModel> GetCats()
        {
            return _context.Cats.OrderByDescending(x => x.Vote).ToList();
        }

        /// <summary>
        /// Get cat by Code
        /// </summary>
        /// <returns></returns>
        public CatModel? GetCatBycode(string code)
        {
            return _context.Cats.Where(x => x.Code == code).FirstOrDefault();
        }

        /// <summary>
        /// Update a cat
        /// </summary>
        /// <returns></returns>
        public async Task<bool> UpdateCat(CatModel catModel)
        {
            _context.Cats.Update(catModel);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
