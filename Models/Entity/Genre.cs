namespace ListGames.Models.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GameEntity> GameEntities { get; set; }
    }
}
