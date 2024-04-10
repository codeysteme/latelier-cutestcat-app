using System.Text.Json.Serialization;

namespace LAtelier.CutestCatApi.Api.Controllers.Cat.Model.Responses
{
    public class CatResponse
    {
        /// <summary>
        /// The Id
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The code identifier of cat
        /// </summary>
        /// <example>MTgwODA3MA</example>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Cat assets images
        /// </summary>
        /// <example>http://24.media.tumblr.com/tumblr_m82woaL5AD1rro1o5o1_1280.jpg</example>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// The vote count
        /// </summary>
        /// <example>1</example>
        [JsonPropertyName("vote")]
        public int Vote { get; set; }
    }
}
