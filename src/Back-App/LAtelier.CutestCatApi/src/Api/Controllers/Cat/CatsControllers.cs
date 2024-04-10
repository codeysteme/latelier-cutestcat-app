using LAtelier.CutestCatApi.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LAtelier.CutestCatApi.Api.Controllers.Cat
{
    /// <summary>
    /// CatsController base
    /// </summary>
    [ApiController]
    [Route("api/cats")]
    public partial class CatsControllers : ControllerBase
    {
        /// <summary>
        /// Manager for all cat operations
        /// </summary>
        private readonly ICatsManagerService _catsManagerService;

        public CatsControllers(ICatsManagerService catsManagerService)
        {
            _catsManagerService = catsManagerService;
        }
    }
}
