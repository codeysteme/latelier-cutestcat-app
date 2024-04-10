using LAtelier.CutestCatApi.Domain.Entities;

namespace LAtelier.CutestCatApi.Domain.Interfaces
{
    public interface ICatsManagerService
    {
        /// <summary>
        /// Get all cats available
        /// </summary>
        /// <returns></returns>
        IEnumerable<CatModel> GetCats();

        /// <summary>
        /// Get cat by Code
        /// </summary>
        /// <returns></returns>
        CatModel? GetCatBycode(string code);

        /// <summary>
        /// Update a cat
        /// </summary>
        /// <returns></returns>
        Task<bool> UpdateCat(CatModel catModel);
    }
}
