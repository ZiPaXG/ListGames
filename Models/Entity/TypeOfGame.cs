namespace ListGames.Models.Entity
{
    public class TypeOfGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<GameEntity> GameEntities { get; set; }
    }
}
