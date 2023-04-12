using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPro_1
{
    public abstract class Transport : IPeapleInTransport
    {
        

        private string? nameOfTransport = default;

        private int comfortStars = default;
        public string NameOfTransport { set { nameOfTransport = value; } }

        Random random = new Random();
        public abstract int NumPeople();
        protected virtual double WeightTransport()
        {
            return random.Next(20,60);
        }
        public virtual void ShowInfo()
        {
            comfortStars = random.Next(1, 5);
            Console.WriteLine("Name of transport: {0}\n" +
                "Ease of movement: {1}", nameOfTransport, Helppppppp.ComfortStars(comfortStars));
        }
    }
}
