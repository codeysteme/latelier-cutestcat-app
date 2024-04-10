using LAtelier.CutestCatApi.Domain.Entities;
using LAtelier.CutestCatApi.Domain.Interfaces;

namespace LAtelier.CutestCatApi.Domain.Services
{
    public class CatsManagerService : ICatsManagerService
    {
        private readonly ICatsRepository _catsRepository;

        /// <summary>
        /// the ctor
        /// </summary>
        /// <param name="catsRepository"></param>
        public CatsManagerService(ICatsRepository catsRepository)
        {
            _catsRepository = catsRepository;
        }

        /// <summary>
        /// Get cat by Code
        /// </summary>
        /// <returns></returns>
        public CatModel? GetCatBycode(string code)
        {
            return _catsRepository.GetCatBycode(code);
        }

        /// <summary>
        /// Get all cats available
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatModel> GetCats()
        {
            var catList = _catsRepository.GetCats();

            return catList;
        }

        /// <summary>
        /// Update a cat
        /// </summary>
        /// <returns></returns>
        public async Task<bool> UpdateCat(CatModel catModel)
        {
            return await _catsRepository.UpdateCat(catModel);
        }
    }
}