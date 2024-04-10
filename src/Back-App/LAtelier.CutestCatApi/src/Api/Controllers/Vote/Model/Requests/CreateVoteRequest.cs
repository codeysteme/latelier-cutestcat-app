using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LAtelier.CutestCatApi.Api.Controllers.Vote.Model.Requests
{
    public class CreateVoteRequest
    {
        /// <summary>
        /// client email
        /// </summary>
        /// <example>nkounkounicephore@gmail.com</example>
        [JsonPropertyName("email")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// the cat code 
        /// </summary>
        /// <example>ghbc</example>
        [JsonPropertyName("catCode")]
        [MinLength(2)]
        public string CatCode { get; set; }
    }
}
