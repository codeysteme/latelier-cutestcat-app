using LAtelier.CutestCatApi.Api.Common.Models;
using LAtelier.CutestCatApi.Api.Controllers.Vote.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace LAtelier.CutestCatApi.Api.Controllers.Vote
{
    public partial class VotesController : ControllerBase
    {
        /// <summary>
        /// Create a vote for a cat 
        /// </summary>
        /// <param name="createVoteRequest">request for vote</param>
        /// <returns></returns>
        /// <remarks>
        /// example request:
        ///
        ///     POST api/votes
        ///     {
        ///         "email": "nkounkounicephore@gmail.com",
        ///         "catCode": "9pu"
        ///     }
        /// </remarks>
        /// <response code="201">The vote is success</response> 
        /// <response code="400">Bad request provided</response> 
        /// <response code="409">Bad request provided</response> 
        /// <response code="500">Internal server error</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ServerError))]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task<IActionResult> CreateVote([FromBody][Required] CreateVoteRequest request)
        {
            try
            {
                var isSuccess = await _votesManagerService.CreateVote(request.Email, request.CatCode).ConfigureAwait(false);
                if (isSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, new { message = "Vote is created successfully !" });
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("DUPLICATED"))
                {
                    return new ConflictObjectResult(new { message = "Vote already exist for this user email and CatCode !" });
                }
            }

            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}
