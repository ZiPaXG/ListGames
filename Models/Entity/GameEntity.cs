namespace ListGames.Models.Entity
{
    public class GameEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int GenreId { get; set; }
        public string DateOfCreate { get; set; }
        public int TypeOfGameId { get; set; }
        public string Author { get; set; }
        public float Price { get; set;}

        public override string ToString()
        {
            return $"Id = {Id}\n" +
                $"Name = {Name}\n" +
                $"Descriptiom = {Description}\n" +
                $"DateOfCreate = {DateOfCreate}\n" +
                $"Author = {Author}\n" +
                $"Price = {Price}\n" +
                $"TypeOfGameId = {TypeOfGameId}\n" +
                $"GenreId = {GenreId}\n";
        }
    }
}
