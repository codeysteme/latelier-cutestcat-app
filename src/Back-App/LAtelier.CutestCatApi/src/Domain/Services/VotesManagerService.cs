using LAtelier.CutestCatApi.Domain.Interfaces;

namespace LAtelier.CutestCatApi.Domain.Services
{
    public class VotesManagerService : IVotesManagerService
    {
        private readonly IVotesRepository _votesRepository;
        private readonly ICatsManagerService _catsManagerService;

        /// <summary>
        /// the ctor
        /// </summary>
        /// <param name="votesRepository"></param>
        public VotesManagerService(IVotesRepository votesRepository, ICatsManagerService catsManagerService)
        {
            _votesRepository = votesRepository;
            _catsManagerService = catsManagerService;
        }

        /// <summary>
        /// Create a simple vote
        /// </summary>
        /// <param name="email"></param>
        /// <param name="catCode"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> CreateVote(string email, string catCode)
        {
            var IsVoteSucess = await _votesRepository.CreateVote(email, catCode);
            if (IsVoteSucess)
            {
                var cat = _catsManagerService.GetCatBycode(catCode);
                cat.Vote++;
                IsVoteSucess = await _catsManagerService.UpdateCat(cat).ConfigureAwait(false);
            }

            return IsVoteSucess;
        }
    }
}
