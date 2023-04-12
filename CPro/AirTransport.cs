namespace CPro_1
{
    public class AirTransport : Transport, IPassegers, ICrew
    {
        private int crew = 2;
        private int passegers = default;
        private double speed = default;

        public int Crew { set { crew = value; } }
        public int Passegers { set { passegers = value; } }
        public double Speed { set { speed = value; } }

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
                "Weight transport: {1}\n" +
                "Speed plane: {2}", NumPeople(), WeightTransport(), speed);
        }
    }
}
