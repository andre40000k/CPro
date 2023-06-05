using CPro_1.Enums;

namespace CPro_1.ReflectionTask
{
    public static class SetValuePropertyInObject
    {

        public static object SetPropValueTransport<T>(string[] valueProperties)
        {
            object? obj = Activator.CreateInstance<T>();
            return SetPropValueTransport(obj, valueProperties, typeof(T));
        }

        public static object SetPropValueTransport(Type typeTransport)
        {
            object? obj = Activator.CreateInstance(typeTransport);
            var properties = typeTransport.GetProperties();

            string[] valueProperties = new string[properties.Length];

            int i = 0;
            foreach(var property in properties)
            {
                Console.Write("Ebtered property {0}: ", property.Name);
                valueProperties[i] = Console.ReadLine();

                i++;
            }

            return SetPropValueTransport(obj, valueProperties, typeTransport);
        }

        private static object SetPropValueTransport(object obj, string[] valueProperties, Type typeObject)
        {           

            if(obj== null )
            {
                return null;
            }

            var properties = typeObject.GetProperties();


            int i = 0;
            foreach (var property in properties)
            {
                var propType = property.PropertyType;

                if (propType.IsClass && !propType.IsPrimitive && propType != typeof(string))
                {

                    var comProperties = propType.GetProperties();

                    foreach (var comProperty in comProperties)
                    {

                        var propNam = comProperty.Name;

                        var propertyValue = property.GetValue(obj);

                        if (propertyValue == null)
                        {
                            propertyValue = Activator.CreateInstance(propType);
                        }

                        property.SetValue(obj, propertyValue);
                        var nestedPropertyInfo = propType.GetProperty(propNam);

                        if (propType.Name == "BaseEngine")
                        {
                            var testLegacy = (TypeEngineEnum)Enum.Parse(typeof(TypeEngineEnum), valueProperties[i]);                            
                            nestedPropertyInfo.SetValue(propertyValue, testLegacy);
                        } 
                        else if(propType.Name == "DoorPosition")
                        {
                            var testLegacy = (OpenCloseEnum)Enum.Parse(typeof(OpenCloseEnum), valueProperties[i]);
                            nestedPropertyInfo.SetValue(propertyValue, testLegacy);
                        }
                        else if (propType.Name == "MoveTransport")
                        {
                            nestedPropertyInfo.SetValue(propertyValue, valueProperties[i]);
                        }
                    }

                }
                else
                {
                    var valueProperty = Convert.ChangeType(valueProperties[i], propType);
                    property.SetValue(obj, valueProperty);
                }
                ++i;
            }


            return obj;

        }

    }
}
