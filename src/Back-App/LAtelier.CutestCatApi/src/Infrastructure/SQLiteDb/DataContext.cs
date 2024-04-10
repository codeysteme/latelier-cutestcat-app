using LAtelier.CutestCatApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LAtelier.CutestCatApi.Infrastructure.SQLiteDb
{
    public class DataContext : DbContext
    {
        public DbSet<CatModel> Cats { get; set; }
        public DbSet<VoteModel> Votes { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatModel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Code);
                entity.Property(e => e.Url);
                entity.Property(e => e.Vote);

                entity.HasData(new CatModel
                {
                    Id = 1,
                    Url = "http://24.media.tumblr.com/tumblr_m82woaL5AD1rro1o5o1_1280.jpg",
                    Code = "MTgwODA3MA",
                    Vote = 12
                });
            });
        }
    }
}
