using CPro_1.Helper;

namespace CPro_1.ReflectionTask
{
    public static class SetValue
    {
        public static void SetValueTransport<T>(T transports)
        {

            Console.Write("Write name property: ");
            string prop = WorkWithString.RegistersFirstUpString(Console.ReadLine());

            if (string.IsNullOrEmpty(prop))
            {
                Console.WriteLine("Property is null!!!");
                return;
            }

            Console.Write("Write value property: ");
            object value = Console.ReadLine();

            var property = typeof(T).GetProperty(prop);
            property.SetValue(transports, value);

            //Console.WriteLine(propValue);
        }

    }
}
