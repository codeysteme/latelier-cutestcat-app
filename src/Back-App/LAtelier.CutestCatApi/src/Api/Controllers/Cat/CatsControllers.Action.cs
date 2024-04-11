using LAtelier.CutestCatApi.Api.Common.Helpers;
using LAtelier.CutestCatApi.Api.Common.Models;
using LAtelier.CutestCatApi.Api.Controllers.Cat.Model.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace LAtelier.CutestCatApi.Api.Controllers.Cat
{
    public partial class CatsControllers : ControllerBase
    {
        /// <summary>
        /// Get all cats data
        /// </summary>
        /// <returns></returns>
        /// <response code="200">The cat list is found</response> 
        /// <response code="204">No Cats found</response> 
        /// <response code="409">Bad request provided</response> 
        /// <response code="500">Internal server error</response> 
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CatResponse>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ServerError))]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetCats()
        {
            var catsList = _catsManagerService.GetCats();

            return catsList.Any() ? Ok(catsList.ToCatResponses()) : NoContent();
        }

        /// <summary>
        /// Get cat details by code
        /// </summary>
        /// <returns></returns>
        /// <response code="200">The cat is found</response> 
        /// <response code="204">No Cat found</response> 
        /// <response code="409">Bad request provided</response> 
        /// <response code="500">Internal server error</response> 
        [HttpGet("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CatResponse))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ServerError))]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult GetCatByCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code) || code.Length < 2)
                return BadRequest("Bad code provided");

            var result = _catsManagerService.GetCatBycode(code);

            return result != null ? Ok(result.ToCatResponse()) : NoContent();
        }
    }
}
