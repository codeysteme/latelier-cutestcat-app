namespace LAtelier.CutestCatApi.Domain.Interfaces
{
    public interface IVotesManagerService
    {
        /// <summary>
        /// create a vote
        /// </summary>
        /// <param name="email"></param>
        /// <param name="catCode"></param>
        /// <returns></returns>
        Task<bool> CreateVote(string email, string catCode);
    }
}
