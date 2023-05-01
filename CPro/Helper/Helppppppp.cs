using CPro_1.Transports;
using CPro_1.Transports.TypeEngine;
using CPro_1.Enums;
using CPro_1.Transports.Door;
using CPro_1.Interface;
using CPro_1.Taska1_4;
using CPro_1.Task7_10;

namespace CPro_1.Helper
{
    public static class Helppppppp
    {
        public static void Task1_4()
        {
            Tasks1_4 tsk = new Tasks1_4();
            tsk.MassNumber = Task1_4GetNumbers();
            tsk.NonPartValue();
            tsk.SqareNonPartValue();
            tsk.SumNumbers();
        }
        public static int[] Task1_4GetNumbers()
        {
            int lenghtMass = 100;
            int[] mass = new int[lenghtMass];

            for (int i = 0; i < lenghtMass; i++)
            {
                mass[i] = RandomValue(0, 100);
            }
            return mass;
        }
        public static int RandomValue(int start, int end)
        {
            Random rnd = new Random();
            return rnd.Next(start, end);
        }
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
            List<AutomobileTransport> autoTransports = new List<AutomobileTransport>()
            {
                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS), 
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID), 
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID), 
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000), 
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC), 
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000), 
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS),
                new DoorPosition(OpenCloseEnum.Close), "Going") 
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.GIBRID),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.ELECTRIC),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },

                new AutomobileTransport(new BaseEngine(TypeEngineEnum.DVS),
                new DoorPosition(OpenCloseEnum.Close), "Going")
                {
                    NameOfTransport = "Car",
                    WeightAutoTransport = RandomValue(1000, 2000),
                    Speed = RandomValue(0, 200),
                    Passegers = RandomValue(0, 4)
                },
            };

            //foreach (AutomobileTransport transport in autoTransports)
            //{
            //    ShowInformation(transport);
            //}

            LINQ_Task7_10 tsk7_10 = new LINQ_Task7_10();
            tsk7_10.Task7(autoTransports);
            Delimetr();
            tsk7_10.Task8(autoTransports);
            Delimetr();
            tsk7_10.Task9(autoTransports);
            Delimetr();
            tsk7_10.Task10(autoTransports);

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

            //foreach (RailwayTransport transport in trainTransports)
            //{
            //    ShowInformation(transport);
            //}

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

            //foreach (AirTransport transport in airTransports)
            //{
            //    ShowInformation(transport);
            //}


            //Task1_4();
        }        
    }
}
