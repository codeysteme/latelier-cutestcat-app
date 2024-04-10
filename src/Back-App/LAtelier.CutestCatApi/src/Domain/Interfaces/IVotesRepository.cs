using LAtelier.CutestCatApi.Domain.Entities;

namespace LAtelier.CutestCatApi.Domain.Interfaces
{
    public interface IVotesRepository
    {
        /// <summary>
        /// Get vote from data Base
        /// </summary>
        /// <param name="email"></param>
        /// <param name="catCode"></param>
        /// <returns></returns>
        VoteModel? GetVote(string email, string catCode);

        /// <summary>
        /// create a vote
        /// </summary>
        /// <param name="email"></param>
        /// <param name="catCode"></param>
        /// <returns></returns>
        Task<bool> CreateVote(string email, string catCode);
    }
}
