using CPro_1.Helper;

namespace CPro_1.ReflectionTask
{
    public static class GetValue
    {
        public static void GetValueTransport<T>(T transports) 
        {          

            Console.Write("Write name property: ");
            string prop = WorkWithString.RegistersString(Console.ReadLine());

            if(string.IsNullOrEmpty(prop))
            {
                Console.WriteLine("Property is null!!!");
                return;
            } 
            
            var property = typeof(T).GetProperty(prop);
            var propValue = property.GetValue(transports);

            Console.WriteLine(propValue); 

        }
    }
}
