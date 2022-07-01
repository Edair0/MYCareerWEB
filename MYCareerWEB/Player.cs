namespace MYCareerWEB
{
    public class Player
    {
        public string FirstName { get; private set; }
        public string NickName { get; private set; }
        public string LastName { get; private set; }
        public int Position { get; private set; }
        public int Height { get; private set; }

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
