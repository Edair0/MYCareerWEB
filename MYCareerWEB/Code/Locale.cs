namespace MYCareerWEB.Code
{
    public class Locale
    {
        public string[] OffensePost { get; set; }
        public string[] OffenseInside { get; set; }
        public string[] OffenseShooting { get; set; }
        public string[] OffensePlaymaking { get; set; }
        public string[] DefenseContesting { get; set; }
        public string[] DefenseDefending { get; set; }
        public string[] AthleticismMovement { get; set; }
        public string[] AthleticismPhysical { get; set; }
        public string[] MentalDefenseIQ { get; set; }
        public string[] MentalConsistency { get; set; }


        public Locale()
        {
            SetupEnglish();
        }
       
        public void SetupEnglish()
        {
            OffensePost = new string[] { "Post Fade", "Post Hook", "Post Control", "Draw Foul" };
            OffenseInside = new string[] { "Driving Layup", "Offensive Rebound", "Standing Dunk", "Driving Dunk" };
            OffenseShooting = new string[] { "Close Shot", "Mid Range Shot", "Three Point Shot", "Free Throw", "Shot IQ" };
            OffensePlaymaking = new string[] { "Ball Handle", "Pass IQ", "Pass Accuracy", "Pass Vision", "Hands" };

            DefenseContesting = new string[] { "Interior Defense", "Perimeter Defense", "Shot Contest" };
            DefenseDefending = new string[] { "Defensive Rebound", "Block", "Steal" };

            AthleticismMovement = new string[] { "Lateral Quickness", "Speed", "Speed With Ball", "Acceleration" };
            AthleticismPhysical = new string[] { "Vertical", "Strength", "Stamina", "Hustle" };

            MentalDefenseIQ = new string[] { "Pass Perception", "Help Defense IQ", "Pick And Roll Defense IQ" };
            MentalConsistency = new string[] { "Defensive Consistency", "Offensive Consistency", "Intangibles" };
        }

    }
}
