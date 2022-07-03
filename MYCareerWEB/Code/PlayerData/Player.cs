using MYCareerWEB.Code.PlayerData.Attribute;

namespace MYCareerWEB.Code.PlayerData
{
    public class Player
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? NickName { get; set; }
        public string? LastName { get; set; }
        public int Position { get; set; }
        public int Height { get; set; }
        public Attributes? Attributes { get; set; }

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

            Attributes = new Attributes();
        }
    }
}
