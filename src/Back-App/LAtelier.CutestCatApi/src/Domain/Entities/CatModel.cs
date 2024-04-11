using System.ComponentModel.DataAnnotations;

namespace LAtelier.CutestCatApi.Domain.Entities
{
    public class CatModel
    {
        [Key]
        public int Id { get; set; }

        [MinLength(2)]
        public string Code { get; set; }

        [MinLength(25)]
        public string Url { get; set; }

        public int Vote { get; set; }
    }
}
