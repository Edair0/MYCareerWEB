
namespace MYCareerWEB.Code.PlayerData.Badge
{
    public class Badges
    {
        public int XP { get; set; }
        public InsideScoring Finishing { get; set; }
        public OutsideScoring Shooting { get; set; }
        public Playmaking Playmaking { get; set; }
        public Defending Defending { get; set; }
        public Athleticism Athleticism { get; set; }
        public Rebounding Rebounding { get; set; }

        public Badges()
        {
            XP = 0;
            Finishing = new InsideScoring();
            Shooting = new OutsideScoring();
            Playmaking = new Playmaking();
            Defending = new Defending();
            Athleticism = new Athleticism();
            Rebounding = new Rebounding();    
        }
    }
}
