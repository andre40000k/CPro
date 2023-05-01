using CPro_1.Helper;
using CPro_1.Transports;

namespace CPro_1.Task7_10
{
    public class LINQ_Task7_10
    {

        public void Task7 (List<AutomobileTransport> automobileTransports)
        {
            Console.WriteLine("\n\n Task 7 \n\n");
            var result = automobileTransports.Where(speed => speed.Speed > 100)
                .Select(weight => weight.WeightAutoTransport);

            foreach (var weight in result)
            {
                Console.WriteLine("The weight of car, thet moving faster then 100 km/h is: {0} kg\n", weight);
            }
        }

        public void Task8(List<AutomobileTransport> automobileTransports)
        {
            Console.WriteLine("\n\n Task 8 \n\n");
            var result = automobileTransports.Where(speed => speed.Speed > 100)
                .Select(x => new { x.WeightAutoTransport, x.Passegers })
                .OrderBy(x => x.WeightAutoTransport);

            foreach (var information in result)
            {
                Console.WriteLine("The weight of car, thet moving faster then 100 km/h is: {0} kg\n" +
                    "The nember of passegers is: {1}\n"
                    , information.WeightAutoTransport, information.Passegers);
            }
        }

        public void Task9(List<AutomobileTransport> automobileTransports)
        {
            Console.WriteLine("\n\n Task 9 \n\n");
            var result = automobileTransports.Where(speed => speed.Speed > 100)
                .OrderBy(x => x.WeightAutoTransport)
                .GroupBy(x => x.Speed)                
                .ToDictionary(x => x.Key, 
                x => x.Select(y => new {y.WeightAutoTransport, y.Passegers })                
                );

            foreach(var group in result)
            {
                Console.WriteLine("The key of group: {0}", group.Key);
                foreach (var information in group.Value)
                {
                    Console.WriteLine("The weight of car, thet moving faster then 100 km/h is: {0} kg\n" +
                        "The nember of passegers is: {1}\n"
                        , information.WeightAutoTransport, information.Passegers);
                }
                Helppppppp.Delimetr();
            }
            
        }

        public void Task10(List<AutomobileTransport> automobileTransports)
        {            
            Console.WriteLine("\n\n Task 10 \n\n");
            var result = automobileTransports.Where(speed => speed.Speed > 100).OrderBy(x => x.WeightAutoTransport).Panultimate();
            Console.WriteLine("The panultimate of car, thet moving faster then 100 km/h is: {0} kg", result.WeightAutoTransport);            
        }
    }
}
