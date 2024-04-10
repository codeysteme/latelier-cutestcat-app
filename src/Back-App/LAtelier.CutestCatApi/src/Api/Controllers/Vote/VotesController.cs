using LAtelier.CutestCatApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LAtelier.CutestCatApi.Api.Controllers.Vote
{
    /// <summary>
    /// VotesController base
    /// </summary>
    [ApiController]
    [Route("api/votes")]
    public partial class VotesController : ControllerBase
    {
        /// <summary>
        /// Manager vote operations
        /// </summary>
        private readonly IVotesManagerService _votesManagerService;

        /// <summary>
        /// the ctor
        /// </summary>
        /// <param name="votesManagerService"></param>
        public VotesController(IVotesManagerService votesManagerService)
        {
            _votesManagerService = votesManagerService;
        }
    }
}
