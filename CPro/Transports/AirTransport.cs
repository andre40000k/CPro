using CPro_1.Interface;
using CPro_1.Transports.Door;
using CPro_1.Transports.Movement;
using CPro_1.Transports.TypeEngine;

namespace CPro_1.Transports
{
    public class AirTransport : BaseTransport, IPassegers, ICrew
    {
        private int crew = 2;
        private int passegers = default;

        public AirTransport(BaseEngine baseEngine, DoorPosition doorPosition, string moved) 
            : base(baseEngine, doorPosition, moved)
        {

        }
        public int Crew { set { crew = value; } }
        public int Passegers { set { passegers = value; } }
        public override int NumPeople()
        {
            return crew + passegers;
        }

        protected override double WeightTransport()
        {
            return base.WeightTransport();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number people in transport: {0}\n" +
                "Weight transport: {1}\n", NumPeople(), WeightTransport());
        }
    }
}
