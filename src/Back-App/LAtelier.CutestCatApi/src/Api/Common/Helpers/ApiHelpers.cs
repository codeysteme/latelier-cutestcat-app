using LAtelier.CutestCatApi.Api.Controllers.Cat.Model.Responses;
using LAtelier.CutestCatApi.Domain.Entities;

namespace LAtelier.CutestCatApi.Api.Common.Helpers
{
    public static class ApiHelpers
    {
        /// <summary>
        /// Build a CatResponse from cat Entitie
        /// </summary>
        /// <param name="catModel">Cat Entitie From db</param>
        /// <returns></returns>
        public static CatResponse ToCatResponse(this CatModel catModel)
        {
            return new CatResponse
            {
                Id = catModel.Id,
                Url = catModel.Url,
                Code = catModel.Code,
                Vote = catModel.Vote
            };
        }

        /// <summary>
        /// Build a CatResponses from cat Entities
        /// </summary>
        /// <param name="catModel">Cats Entities From db</param>
        /// <returns></returns>
        public static List<CatResponse> ToCatResponses(this IEnumerable<CatModel> catModels)
        {
            return catModels.Select(a => a.ToCatResponse()).ToList();
        }
    }
}
