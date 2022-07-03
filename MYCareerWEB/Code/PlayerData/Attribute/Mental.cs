namespace MYCareerWEB.Code.PlayerData.Attribute
{
    public class Mental
    {
        public int PassPerception { get; set; }
        public int DefensiveConsistency { get; set; }
        public int HelpDefenseIQ { get; set; }
        public int OffensiveConsistency { get; set; }
        public int PickAndRollDefenseIQ { get; set; }
        public int Intangibles { get; set; }

        public Mental()
        {
            PassPerception = 50;
            DefensiveConsistency = 50;
            HelpDefenseIQ = 50;
            OffensiveConsistency = 50;
            PickAndRollDefenseIQ = 50;
            Intangibles = 50;
        }


    }
}
