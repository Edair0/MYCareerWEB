using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;

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
            SetStartingStats(25);
            SetStartingXP(100000);
        }

        public void SetStartingStats(int Stat)
        {
            Array.Fill(Offense.Inside, Stat);
            Array.Fill(Offense.Post, Stat);
            Array.Fill(Offense.Shooting, Stat);
            Array.Fill(Offense.Playmaking, Stat);
            Array.Fill(Defense.Contesting, Stat);
            Array.Fill(Defense.Defending, Stat);
            Array.Fill(Athleticism.Movement, Stat);
            Array.Fill(Athleticism.Physical, Stat);
            Array.Fill(Mental.DefenseIQ, Stat);
            Array.Fill(Mental.Consistency, Stat);
        }

        public void SetStartingXP(int XP)
        {
            Offense.Inside[0] = XP;
            Offense.Post[0] = XP;
            Offense.Shooting[0] = XP;
            Offense.Playmaking[0] = XP;
            Defense.Defending[0] = XP;
            Defense.Contesting[0] = XP;
            Athleticism.Movement[0] = XP;
            Athleticism.Physical[0] = XP;
            Mental.DefenseIQ[0] = XP;
            Mental.Consistency[0] = XP;
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
