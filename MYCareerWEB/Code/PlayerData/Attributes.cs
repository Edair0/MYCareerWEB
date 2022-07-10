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
        public AttributeData Post { get; set; }
        public AttributeData Inside { get; set; }
        public AttributeData Shooting { get; set; }
        public AttributeData Playmaking { get; set; }

        public OffenseGroup()
        {
            Post = new AttributeData(4);
            Inside = new AttributeData(4);
            Shooting = new AttributeData(5);
            Playmaking = new AttributeData(5);
        }
    }

    public class DefenseGroup
    {
        public AttributeData Contesting { get; set; }
        public AttributeData Defending { get; set; }

        public DefenseGroup()
        {
            Contesting = new AttributeData(3);
            Defending = new AttributeData(3);
        }
    }

    public class AthleticismGroup
    {
        public AttributeData Movement { get; set; }
        public AttributeData Physical { get; set; }

        public AthleticismGroup()
        {
            Movement = new AttributeData(4);
            Physical = new AttributeData(4);
        }
    }

    public class MentalGroup
    {
        public AttributeData DefenseIQ { get; set; }
        public AttributeData Consistency { get; set; }

        public MentalGroup()
        {
            DefenseIQ = new AttributeData(3);
            Consistency = new AttributeData(3);
        }
    }

    public class AttributeData
    {
        public int XP { get; set; }
        public int[] Level { get; set; }

        public AttributeData(int AttributesNumer)
        {
            XP = 0;
            Level = new int[AttributesNumer];
            Array.Fill(Level, 25);
        }
    }


    public enum AttributeType
    {
        Offense = 0,
        Defense = 1,
        Athleticism = 2,
        Mental = 3,
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
