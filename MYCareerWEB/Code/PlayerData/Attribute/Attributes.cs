namespace MYCareerWEB.Code.PlayerData.Attribute

{
    public class Attributes
    {
        public int XP { get; set; }
        public Offense Offense { get; set; }
        public Defense Defense { get; set; }
        public Athleticism Athleticism { get; set; }
        public Mental Mental { get; set; }

        public Attributes()
        {
            XP = 0;
            Offense = new Offense();
            Defense = new Defense();
            Athleticism = new Athleticism();
            Mental = new Mental();
        }
    }
}
