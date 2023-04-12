using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPro_1
{
    public class RailwayTransport : Transport, IPassegers, ICrew
    {
        private int crew = 2;
        private int passegers = default;
        private int numberOfWagons = default;

        public int Crew { set { crew = value; } }
        public int Passegers { set { passegers = value; } }
        public double NumberOfWagons { set { numberOfWagons = (int)value; } }

        public override int NumPeople()
        {
            return crew + passegers;
        }

        protected override double WeightTransport()
        {
            return base.WeightTransport() * (numberOfWagons + 1);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Number people in transport: {0}\n" +
                "Weight transport: {1}", NumPeople(), WeightTransport() );
        }
    }
}
