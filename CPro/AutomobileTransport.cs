using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPro_1
{
    public class AutomobileTransport : Transport, ICrew, IPassegers
    {
        private int crew = 1;
        private int passegers = default;
        private double weightAutoTransport = default;

        public int Crew { set { crew = value; } }
        public int Passegers { set { passegers = value; } }
        public double WeightAutoTransport { set { weightAutoTransport = value; } }

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
                "Weight transport: {1}", NumPeople(), WeightTransport());
        }
    }
}
