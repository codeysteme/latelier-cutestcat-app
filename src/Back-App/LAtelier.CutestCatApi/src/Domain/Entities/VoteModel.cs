using System.ComponentModel.DataAnnotations;

namespace LAtelier.CutestCatApi.Domain.Entities
{
    public class VoteModel
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        public string Email { get; set; }

        [MinLength(25)]
        public string CatCode { get; set; }
    }
}
