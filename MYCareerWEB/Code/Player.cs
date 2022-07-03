namespace MYCareerWEB.Code
{
    public class Player
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? NickName { get; set; }
        public string? LastName { get; set; }
        public int Position { get; set; }
        public int Height { get; set; }
        public int XP { get; set; }
        public int BadgeXP { get; set; }

        public Player()
        {

        }
        public Player(string firstName, string nickName, string lastName, int position, int height)
        {
            FirstName = firstName;
            NickName = nickName;
            LastName = lastName;
            Position = position;
            Height = height;
        }
    }
}
