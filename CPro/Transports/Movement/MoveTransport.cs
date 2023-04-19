
namespace CPro_1.Transports.Movement
{
    public class MoveTransport
    {
        public MoveTransport() 
        {
            Move = "Stand";
        }
        public MoveTransport(string move) 
        {
            Move = move;
        }

        public string Move { get; private set; }
    }
}
