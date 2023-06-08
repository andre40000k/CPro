using CPro_1.Helper;
using CPro_1.Interface;
using CPro_1.ReflectionTask;
using CPro_1.Transports;

namespace CPro_1.ReadFile
{
    public static class Read<T> where T : IGetInformation, IGetSpeed, IEngeen
    {
        public static async Task<List<T>> ReadFiles(string path/*, CancellationToken token*/)
        {            
            var transports = new List<T>();

            using (var streamReader = new StreamReader(path))
            {
                string? line;                

                while ((line = streamReader.ReadLine()) != null)
                {

                    //if (token.IsCancellationRequested)
                    //{
                    //    Console.WriteLine("***************************************************************************************");
                    //    break;
                    //}

                    var parameters = line.Split(',');
                    transports.Add((T)SetValuePropertyInObject.SetPropValueTransport<T>(parameters));
                    
                    await Task.Delay(100);
                }
            }

            return transports;
        }

        private static void PushIf(List<T> transports)
        {
            foreach (var transport in transports)
            {
                Helppppppp.ShowInformation(transport);
            }
        }

        private static int GetTypeTransport()
        {            
            if(typeof(AutomobileTransport).IsAssignableFrom(typeof(T)))
                return  1;
            else if(typeof(AirTransport).IsAssignableFrom(typeof(T)))
                return 2;
            else if(typeof(RailwayTransport).IsAssignableFrom(typeof(T)))
                return 3;

            return 0;
        }  
        
    }
}
