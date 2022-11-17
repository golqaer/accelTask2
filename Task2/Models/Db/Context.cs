using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Task2.Models.Db
{
    public class Context : DbContext
    {
        public DbSet<DbAccountModel> Accounts { get; set; }
        public DbSet<DbBookModel> Books { get; set; }

        public Context(DbContextOptions<Context> options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbAccountModel>().HasData(
                    new DbAccountModel { Id = 1, Name = "admin", Password = "000000"}
                );

            modelBuilder.Entity<DbBookModel>().HasData(
                    new DbBookModel
                    {
                        Id = 1,
                        Name = "Level Up",
                        Author = "Данияр Сугралинов",
                        PageCount = 160,
                        CoverFileName = "31733eab-c3d2-4899-bccc-53535b220b06.jpg",
                        Description = "Фил — тридцатилетний безработный геймер, подрабатывающий написанием статей на фрилансе и ведением блога. В день, когда он получает способность видеть наш мир через загадочный виртуальный интерфейс, похожий на элемент компьютерной игры, его бросает жена, а сам он остается без денег, без продуктов и без целей в жизни.",
                        Date = DateTime.Parse("27.11.2017")
                    }
                );
        }
    }
}
