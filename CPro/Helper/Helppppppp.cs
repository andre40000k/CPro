using CPro_1.Transports;
using CPro_1.Interface;
using CPro_1.Taska1_4;
using CPro_1.Task7_10;
using CPro_1.ReadFile;
using CPro_1.ReflectionTask;

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
            stat.InterestingPlaces();
            stat.FinalDistance(speed);
        }

        private static void CreateObjectTipes(double speed)
        {
            var transportInformation = new TrasportInformation<Statistics>();
            var transStatistic = transportInformation.WriteInformation();
            transStatistic.Statistics(speed);
        }

        public static void ShowInformation<T>(this T transport) where T : IGetInformation, IGetSpeed, IEngeen
        {
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

        public static void LinqTask7_10<T>(List<T> transport) 
        {
            LINQ_Task7_10 tsk7_10 = new LINQ_Task7_10();
            //tsk7_10.Task7(transport);
            //Delimetr();
            //tsk7_10.Task8(transport);
            //Delimetr();
            //tsk7_10.Task9(transport);
            //Delimetr();
            //tsk7_10.Task10(transport);
        }

        public static async Task<List<AutomobileTransport>> StartLists()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            string[] path =
            {
                "DataBaseAutoTransport.txt",
                "DataBaseAirTransport.txt",
                "DataBaseReilwayTransport.txt"
            };

            Task<List<AutomobileTransport>> task = Task.Run(() => Read<AutomobileTransport>.ReadFiles("DataBaseAutoTransport.txt"));
            List<AutomobileTransport> tr = await task;

            List<AutomobileTransport> automobileTransports = new List<AutomobileTransport>();
            automobileTransports.AddRange(tr);

            //GetValue.GetValueTransport(automobileTransports[0]);

            //PrintValue.PrintPropValueTransport(automobileTransports[0]);
                        
            //List<Task> tasks = new List<Task>
            //{
            //        Task.Run(() => Read<RailwayTransport>.ReadFiles(path[2], token), token),
            //        Task.Run(() => Read<AutomobileTransport>.ReadFiles(path[0], token), token),
            //        Task.Run(() => Read<AirTransport>.ReadFiles(path[1], token),token)
            //};
            //await Task.WhenAny(tasks);
            //cts.Cancel();
            //await Task.WhenAll(task);
            return automobileTransports;
        }

        public static async void RunScript()
        {
            var allTransports =  StartLists().GetAwaiter().GetResult();

            allTransports.Add((AutomobileTransport)SetValuePropertyInObject.SetPropValueTransport(typeof(AutomobileTransport)));

            foreach (var transport in allTransports)
            {
                ShowInformation(transport);
            }

            //PrintValue.PrintPropValueTransport(a[0]);



        }
    }
}
