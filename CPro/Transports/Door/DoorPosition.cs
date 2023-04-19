using CPro_1.Enums;

namespace CPro_1.Transports.Door
{
    public class DoorPosition
    {
        public DoorPosition() { }   
        public DoorPosition(OpenCloseEnum openClose) 
        {
            OpenClose = openClose;
        }
        public OpenCloseEnum OpenClose { get; set; }
    }
}
