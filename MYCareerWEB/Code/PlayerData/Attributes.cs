using System;
using System.ComponentModel;
using System.Reflection.Emit;

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
        public int[] Post { get; set; }
        public int[] Inside { get; set; }
        public int[] Shooting { get; set; }
        public int[] Playmaking { get; set; }

        public OffenseGroup()
        {
            Post = new int[4 + 1];
            Inside = new int[4 + 1];
            Shooting = new int[5 + 1];
            Playmaking = new int[5 + 1];
            Array.Fill(Post, 25);
            Array.Fill(Inside, 25);
            Array.Fill(Shooting, 25);
            Array.Fill(Playmaking, 25);
            Post[0] = 0; Inside[0] = 0; Shooting[0] = 0; Playmaking[0] = 0;
        }
    }

    public class DefenseGroup
    {
        public int[] Contesting { get; set; }
        public int[] Defending { get; set; }

        public DefenseGroup()
        {
            Contesting = new int[3 + 1];
            Defending = new int[3 + 1];
            Array.Fill(Contesting, 25);
            Array.Fill(Defending, 25);
            Contesting[0] = 0; Defending[0] = 0;
        }
    }

    public class AthleticismGroup
    {
        public int[] Movement { get; set; }
        public int[] Physical { get; set; }

        public AthleticismGroup()
        {
            Movement = new int[4 + 1];
            Physical = new int[4 + 1];
            Array.Fill(Movement, 25);
            Array.Fill(Physical, 25);
            Movement[0] = 0; Physical[0] = 0;
        }
    }

    public class MentalGroup
    {
        public int[] DefenseIQ { get; set; }
        public int[] Consistency { get; set; }

        public MentalGroup()
        {
            DefenseIQ = new int[3 + 1];
            Consistency = new int[3 + 1];
            Array.Fill(DefenseIQ, 25);
            Array.Fill(Consistency, 25);
            DefenseIQ[0] = 0; Consistency[0] = 0;
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
