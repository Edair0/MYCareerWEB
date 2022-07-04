namespace MYCareerWEB.Code.PlayerData
{
    public class Badges
    {
        public int XP { get; set; }
        public int[] InsideScoring { get; set; }
        public int[] OutsideScoring { get; set; }
        public int[] Playmaking { get; set; }
        public int[] Defending { get; set; }
        public int[] AthleticismRebounding { get; set; }

        public Badges()
        {
            XP = 100000;
            InsideScoring = new int[18];
            OutsideScoring = new int[20];
            Playmaking = new int[21];
            Defending = new int[16];
            AthleticismRebounding = new int[5];
        }
    }

    public enum BadgeType
    {
        InsideScoring = 0,
        OutsideScoring = 1,
        Playmaking = 2,
        Defending = 3,
        AthleticismRebounding = 4,
    }
    public enum InsideScoring
    {
        FearlessFinisher = 0,
        Acrobat = 1,
        TearDropper = 2,
        PostSpinTechnician = 3,
        Dropstepper = 4,
        PutbackBoss = 5,
        HookSpecialist = 6,
        Posterizer = 7,
        BackdownPunisher = 8,
        RiseUp = 9,
        GiantSlayer = 10,
        ProTouch = 11,
        SlitheryFinisher = 12,
        Unstrippable = 13,
        MouseInTheHouse = 14,
        LimitlessTakeoff = 15,
        GraceUnderPressure = 16,
        FastTwitch = 17,
    }
    public enum OutsideScoring
    {
        CatchAndShoot = 0,
        CornerSpecialist = 1,
        DifficultShots = 2,
        MismatchExpert = 3,
        Lucky7 = 4,
        Blinders = 5,
        CircusThrees = 6,
        FadeAce = 7,
        LimitlessSpotUp = 8,
        Chef = 9,
        RhythmShooter = 10,
        SetShooter = 11,
        ClutchShooter = 12,
        Deadeye = 13,
        Sniper = 14,
        StopAndPop = 15,
        GreenMachine = 16,
        HotZoneHunter = 17,
        VolumeShooter = 18,
        SlipperyOffBall = 19,
    }
    public enum Playmaking
    {
        AnkleBreaker = 0,
        Hyperdrive = 1,
        BreakStarter = 2,
        GlueHands = 3,
        Dimer = 4,
        QuickChain = 5,
        BailOut = 6,
        Downhill = 7,
        DreamShake = 8,
        HandlesForDays = 9,
        NeedleThreader = 10,
        QuickFirstStep = 11,
        SpaceCreator = 12,
        StopAndGo = 13,
        TightHandles = 14,
        Unpluckable = 15,
        BulletPasser = 16,
        SpecialDelivery = 17,
        FloorGeneral = 18,
        PostPlaymaker = 19,
        TripleThreatJuke = 20,
    }
    public enum Defending
    {
        PickPocket = 0,
        RimProtector = 1,
        PickDodger = 2,
        ChaseDownArtist = 3,
        Clamps = 4,
        DefensiveLeader = 5,
        Interceptor = 6,
        Intimidator = 7,
        OffBallPest = 8,
        PogoStick = 9,
        PostLockdown = 10,
        TirelessDefender = 11,
        AnkleBraces = 12,
        Menace = 13,
        BallStripper = 14,
        Hustler = 15,
    }
    public enum AthleticismRebounding
    {
        BrickWall = 0,
        LobCityFinisher = 1,
        Box = 2,
        ReboundChaser = 3,
        Worm = 4,
    }
}
