namespace MYCareerWEB.Code.PlayerData.Attribute
{
    public class Defense
    {
        public int DefensiveRebound { get; set; }
        public int InteriorDefense { get; set; }
        public int PerimeterDefense { get; set; }
        public int Block { get; set; }
        public int Steal { get; set; }
        public int ShotContest { get; set; }

        public Defense()
        {
            DefensiveRebound = 50;
            InteriorDefense = 50;
            PerimeterDefense = 50;
            Block = 50;
            Steal = 50;
            ShotContest = 50;
        }


    }
}
