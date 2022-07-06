using MYCareerWEB.Code.PlayerData;

namespace MYCareerWEB.Code
{
    public class Modifiers
    {
        public float[,] OffenseMults;
        public float[,] DefenseMults;
        public float[,] AthleticismMults;
        public float[,] MentalMults;

        public Modifiers()
        {
            OffenseMults = new float[18, 3];
            OffenseMults.AddMults((int)Offense.DrivingLayup, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.PostFade, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.PostHook, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.PostControl, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.DrawFoul, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.CloseShot, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.MidRangeShot, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.ThreePointShot, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.FreeThrow, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.BallHandle, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.PassIQ, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.PassAccuracy, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.OffensiveRebound, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.StandingDunk, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.DrivingDunk, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.ShotIQ, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.PassVision, 1, 1, 1);
            OffenseMults.AddMults((int)Offense.Hands, 1, 1, 1);

            DefenseMults = new float[6, 3];
            DefenseMults.AddMults((int)Defense.DefensiveRebound, 1, 1, 1);
            DefenseMults.AddMults((int)Defense.InteriorDefense, 1, 1, 1);
            DefenseMults.AddMults((int)Defense.PerimeterDefense, 1, 1, 1);
            DefenseMults.AddMults((int)Defense.Block, 1, 1, 1);
            DefenseMults.AddMults((int)Defense.Steal, 1, 1, 1);
            DefenseMults.AddMults((int)Defense.ShotContest, 1, 1, 1);

            AthleticismMults = new float[8, 3];
            AthleticismMults.AddMults((int)Athleticism.LateralQuickness, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.Speed, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.SpeedWithBall, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.Acceleration, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.Vertical, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.Strength, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.Stamina, 1, 1, 1);
            AthleticismMults.AddMults((int)Athleticism.Hustle, 1, 1, 1);

            MentalMults = new float[6, 3];
            MentalMults.AddMults((int)Mental.PassPerception, 1, 1, 1);
            MentalMults.AddMults((int)Mental.DefensiveConsistency, 1, 1, 1);
            MentalMults.AddMults((int)Mental.HelpDefenseIQ, 1, 1, 1);
            MentalMults.AddMults((int)Mental.OffensiveConsistency, 1, 1, 1);
            MentalMults.AddMults((int)Mental.PickAndRollDefenseIQ, 1, 1, 1);
            MentalMults.AddMults((int)Mental.Intangibles, 1, 1, 1);
        }

    }

    public enum ModifierType
    {
        Difficulty = 0,
        Height = 1,
        Weight = 2
    }

    public static class ArrayExtension
    {
        public static void AddMults(this float[,] Array, int Attribute, float Difficulty, float Height, float Weight)
        {
            Array[Attribute, (int)ModifierType.Difficulty] = Difficulty;
            Array[Attribute, (int)ModifierType.Height] = Height;
            Array[Attribute, (int)ModifierType.Weight] = Weight;
        }
    }

}
