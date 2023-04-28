using CPro_1.Transports;
using CPro_1.Transports.TypeEngine;
using CPro_1.Enums;
using CPro_1.Transports.Door;
using CPro_1.Interface;

namespace CPro_1.Helper
{
    public static class Helppppppp
    {
        public static string ComfortStars(int numStars)
        {
            return new string('*', numStars);
        }   
        
        public static void Statistics<T>(this T stat, double speed) where T : class, IDistance, IPlace
        {
            //update
            stat.InterestingPlaces();
            stat.FinalDistance(speed);
        }

        private static void CreateObjectTipes(double speed)
        {
            //update
            var transportInformation = new TrasportInformation<Statistics>();
            var transStatistic = transportInformation.WriteInformation();
            transStatistic.Statistics(speed);
        }

        public static void ShowInformation<T>(T transport) where T : IGetInformation, IGetSpeed, IEngeen
        {
            //update
            Console.ForegroundColor = (ConsoleColor)transport.BaseEngine.ColaredEngine();
            transport.ShowInfo();
            CreateObjectTipes(transport.Speed);
            Delimetr();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Delimetr()
        {
            Console.WriteLine(new string('-', 35));
        }

        public static void RunScript()
        {
            //update
            List<AutomobileTransport> autoTransports = new List<AutomobileTransport>()
            {
                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID), new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = 20,
                    Speed = 110
                }
            };


            foreach (AutomobileTransport transport in autoTransports)
            {
                ShowInformation(transport);
            }

            List<RailwayTransport> trainTransports = new List<RailwayTransport>()
            {
                new RailwayTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Open), "Standing at the train station")
                {
                    Crew = 4,
                    NameOfTransport = "Train",
                    Passegers = 0,
                    NumberOfWagons = 60,
                    Speed = 0
                },

                new RailwayTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "In move")
                {
                    Crew = 5,
                    NameOfTransport = "Train",
                    Passegers = 100,
                    NumberOfWagons = 59,
                    Speed = 61
                }
            };

            foreach (RailwayTransport transport in trainTransports)
            {
                ShowInformation(transport);
            }


            List<AirTransport> airTransports = new List<AirTransport>()
            {
                new AirTransport(new BaseEngine(TypeEngineEnum.DVS),
                    new DoorPosition(OpenCloseEnum.Close), "Flying")
                {
                    NameOfTransport = "Plane",
                    Passegers = 34,
                    Speed = 245
                }
            };


            foreach (AirTransport transport in airTransports)
            {
                ShowInformation(transport);
            }
            
        }
    }
}
