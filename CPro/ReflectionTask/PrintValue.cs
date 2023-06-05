namespace CPro_1.ReflectionTask
{
    public static class PrintValue
    {
        public static void PrintPropValueTransport<T>(T transports)
        {

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(transports);
                var propType = property.PropertyType;                

                if (propType.IsClass && !propType.IsPrimitive && propType != typeof(string))
                {                   

                    var comProperties = propType.GetProperties();

                    foreach (var comProperty in comProperties)
                    {
                        var comPropertyValue = comProperty.GetValue(propertyValue);
                        Console.WriteLine("{0}:{1}", property.Name, comPropertyValue);
                    }                   

                }
                else
                {
                    Console.WriteLine("{0}:{1}", property.Name, propertyValue);
                }
            }

        }
    }
}
