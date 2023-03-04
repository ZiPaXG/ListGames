using ListGames.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace ListGames.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<GameEntity> GameEntities { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<TypeOfGame> Types { get; set; }
        // конфигурация контекста
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // получаем файл конфигурации
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            // устанавливаем для контекста строку подключения
            // инициализируем саму строку подключения
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}