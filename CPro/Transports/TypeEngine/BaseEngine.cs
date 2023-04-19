using CPro_1.Enums;
using CPro_1.Interface;

namespace CPro_1.Transports.TypeEngine
{
    public class BaseEngine : ITypeEngine
    {
        public BaseEngine() { }
        public BaseEngine(TypeEngineEnum typeEngine) 
        {
            TypeEngine = typeEngine;
        }
        public TypeEngineEnum TypeEngine { get; set; }

        public int ColaredEngine()
        {
            return (int)(ColorTypeEngineEnum)(int)(TypeEngineEnum)(int)TypeEngine;
        }

    }
}
