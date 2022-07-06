namespace MYCareerWEB.Code.PlayerData
{
    public class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Position { get; set; }
        public int Height { get; set; }
        public Attributes Attributes { get; set; }
        public Badges Badges { get; set; }

        public Player()
        {
            FullName = String.Empty;
            Attributes = new Attributes();
            Badges = new Badges();
        }

        public Player(string firstName, int position, int height)
        {
            FullName = firstName;
            Position = position;
            Height = height;
            Attributes = new Attributes();
            Badges = new Badges();
        }
    }
}
