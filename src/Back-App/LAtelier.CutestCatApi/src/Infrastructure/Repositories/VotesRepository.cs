using LAtelier.CutestCatApi.Domain.Entities;
using LAtelier.CutestCatApi.Domain.Interfaces;
using LAtelier.CutestCatApi.Infrastructure.SQLiteDb;

namespace LAtelier.CutestCatApi.Infrastructure.Repositories
{

    public class VotesRepository : IVotesRepository
    {
        /// <summary>
        /// the db context
        /// </summary>
        private readonly DataContext _context;

        public VotesRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get vote from data Base
        /// </summary>
        /// <param name="email"></param>
        /// <param name="catCode"></param>
        /// <returns></returns>
        public VoteModel? GetVote(string email, string catCode)
        {
            return _context.Votes.Where(x => x.CatCode.Equals(catCode) && x.Email.Equals(email)).FirstOrDefault();
        }

        /// <summary>
        /// create a vote
        /// </summary>
        /// <param name="email"></param>
        /// <param name="catCode"></param>
        /// <returns></returns>
        public async Task<bool> CreateVote(string email, string catCode)
        {
            var ckeck = GetVote(email, catCode);
            if (ckeck != null)
            {
                throw new Exception("DUPLICATED - Erreur vote already exist");
            }

            await _context.Votes.AddAsync(new VoteModel
            {
                Email = email,
                CatCode = catCode
            });

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
