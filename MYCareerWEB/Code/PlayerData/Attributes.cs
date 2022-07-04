namespace MYCareerWEB.Code.PlayerData
{
    public class Attributes
    {
        public int XP { get; set; }
        public int[] Offense { get; set; }
        public int[] Defense { get; set; }
        public int[] Athleticism { get; set; }
        public int[] Mental { get; set; }

        public Attributes()
        {
            XP = 0;
            Offense = new int[18];
            Defense = new int[6];
            Athleticism = new int[8];
            Mental = new int[6];
        }
    }

    public enum Offense : int
    {
        DrivingLayup = 0,
        PostFade = 1,
        PostHook = 2,
        PostControl = 3,
        DrawFoul = 4,
        CloseShot = 5,
        MidRangeShot = 6,
        ThreePointShot = 7,
        FreeThrow = 8,
        BallHandle = 9,
        PassIQ = 10,
        PassAccuracy = 11,
        OffensiveRebound = 12,
        StandingDunk = 13,
        DrivingDunk = 14,
        ShotIQ = 15,
        PassVision = 16,
        Hands = 17,
    }

    public enum Defense : int
    {
        DefensiveRebound = 0,
        InteriorDefense = 1,
        PerimeterDefense = 2,
        Block = 3,
        Steal = 4,
        ShotContest = 5,
    }

    public enum Athleticism : int
    {
        LateralQuickness = 0,
        Speed = 1,
        SpeedWithBall = 2,
        Acceleration = 3,
        Vertical = 4,
        Strength = 5,
        Stamina = 6,
        Hustle = 7,
    }

    public enum Mental : int
    {
        PassPerception = 0,
        DefensiveConsistency = 1,
        HelpDefenseIQ = 2,
        OffensiveConsistency = 3,
        PickAndRollDefenseIQ = 4,
        Intangibles = 5,
    }
}
