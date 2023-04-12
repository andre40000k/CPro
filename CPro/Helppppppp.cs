using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPro_1
{
    public static class Helppppppp
    {
        public static string ComfortStars(int numStars)
        {
            return new string('*', numStars);
        }
        public static void ShowInformation(Transport transport)
        {
            transport.ShowInfo();
            Delimetr();
        }

        public static void Delimetr() 
        {
            Console.WriteLine(new string('-', 35));
        }

        public static void RunScript()
        {
            var car = new AutomobileTransport
            {
                NameOfTransport = "Car",
                Passegers = 2,
                WeightAutoTransport = 20
            };

            var plane = new AirTransport
            {
                NameOfTransport = "Plane",
                Passegers = 34,
                Speed = 245
            };

            var train = new RailwayTransport
            {
                NameOfTransport = "train",
                Passegers = 0,
                NumberOfWagons = 60
            };

            ShowInformation(car);
            ShowInformation(train);
            ShowInformation(plane);
        }


    }
}
