namespace MYCareerWEB.Code.PlayerData.Attribute
{
    public class Athleticism
    {
        public int LateralQuickness { get; set; }
        public int Speed { get; set; }
        public int SpeedWithBall { get; set; }
        public int Acceleration { get; set; }
        public int Vertical { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Hustle { get; set; }

        public Athleticism()
        {
            LateralQuickness = 50;
            Speed = 50;
            SpeedWithBall = 50;
            Acceleration = 50;
            Vertical = 50;
            Strength = 50;
            Stamina = 50;
            Hustle = 50;
        }


    }
}
