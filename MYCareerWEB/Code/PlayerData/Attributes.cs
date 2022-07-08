using System;

namespace MYCareerWEB.Code.PlayerData
{
    public class Attributes
    {
        public OffenseGroup Offense { get; set; }
        public DefenseGroup Defense { get; set; }
        public AthleticismGroup Athleticism { get; set; }
        public MentalGroup Mental { get; set; }

        public Attributes()
        {
            Offense = new OffenseGroup();
            Defense = new DefenseGroup();
            Athleticism = new AthleticismGroup();
            Mental = new MentalGroup();
        }
    }

    public class OffenseGroup
    {
        public Attribute Post { get; set; }
        public Attribute Inside { get; set; }
        public Attribute Shooting { get; set; }
        public Attribute Playmaking { get; set; }

        public OffenseGroup()
        {
            Post = new Attribute(4);
            Inside = new Attribute(4);
            Shooting = new Attribute(5);
            Playmaking = new Attribute(5);
        }
    }

    public class DefenseGroup
    {
        public Attribute Contesting { get; set; }
        public Attribute Defending { get; set; }

        public DefenseGroup()
        {
            Contesting = new Attribute(3);
            Defending = new Attribute(3);
        }
    }

    public class AthleticismGroup
    {
        public Attribute Movement { get; set; }
        public Attribute Physical { get; set; }

        public AthleticismGroup()
        {
            Movement = new Attribute(4);
            Physical = new Attribute(4);
        }
    }

    public class MentalGroup
    {
        public Attribute DefenseIQ { get; set; }
        public Attribute Consistency { get; set; }

        public MentalGroup()
        {
            DefenseIQ = new Attribute(3);
            Consistency = new Attribute(3);
        }
    }

    public class Attribute
    {
        public int XP { get; set; }
        public int[] Inside { get; set; }

        public Attribute(int AttributesNumer)
        {
            XP = 0;
            Inside = new int[AttributesNumer];
            Array.Fill(Inside, 25);
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
