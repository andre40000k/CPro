using CPro_1.Transports;
using CPro_1.Transports.TypeEngine;
using CPro_1.Enums;
using CPro_1.Transports.Door;
using CPro_1.Transports.Movement;

namespace CPro_1.Helper
{
    public static class Helppppppp
    {
        public static string ComfortStars(int numStars)
        {
            return new string('*', numStars);
        }

        

        public static void ShowInformation(BaseTransport transport)
        {
            Console.ForegroundColor = (ConsoleColor)transport.BaseEngine.ColaredEngine();
            transport.ShowInfo();
            Delimetr();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Delimetr()
        {
            Console.WriteLine(new string('-', 35));
        }

        public static void RunScript()
        {
            DoorPosition carDoor = new DoorPosition(OpenCloseEnum.Close);
            var car = new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID), carDoor, "Going")
            {
                NameOfTransport = "Car",
                WeightAutoTransport = 20
            };

            var plane = new AirTransport(new BaseEngine(TypeEngineEnum.DVS), 
                new DoorPosition(OpenCloseEnum.Close), "Flying")
            {
                NameOfTransport = "Plane",
                Passegers = 34,
                Speed = 245
            };

            var train = new RailwayTransport(new BaseEngine(TypeEngineEnum.ELECTRIC), 
                new DoorPosition(OpenCloseEnum.Open), "Standing at the train station")
            {
                Crew = 4,
                NameOfTransport = "Train",
                Passegers = 0,
                NumberOfWagons = 60
            };

            ShowInformation(car);
            ShowInformation(plane);
            ShowInformation(train);

        }
    }
}
