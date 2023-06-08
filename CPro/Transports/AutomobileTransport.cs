using CPro_1.CustomAttribute;
using CPro_1.Interface;
using CPro_1.Transports.Door;

namespace CPro_1.Transports
{
    public class AutomobileTransport : BaseTransport, ICrew, IPassegers
    {
        private int crew = 1;
        private int passegers = default;
        private double weightAutoTransport = default;

        public AutomobileTransport() {}
        public AutomobileTransport(string baseEngine, DoorPosition doorPosition, string moved) 
            : base(baseEngine, doorPosition, moved) { }

        public int Crew { get => crew; set { crew = value; } }
        [Display]
        [SetValue]
        public int Passegers { get => passegers; set { passegers = value; } }
        [SetValue]
        public double WeightAutoTransport { get => weightAutoTransport;  set { weightAutoTransport = value; } }
        

        public override int NumPeople()
        {
            return crew + passegers;
        }

        protected override double WeightTransport()
        {
            return weightAutoTransport;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number people in transport: {0}\n" +
                "Weight transport: {1}\n", NumPeople(), WeightTransport());
        }
    }
}
