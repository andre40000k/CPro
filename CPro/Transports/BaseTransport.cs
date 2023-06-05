using CPro_1.Helper;
using CPro_1.Interface;
using CPro_1.Transports.Door;
using CPro_1.Transports.TypeEngine;
using CPro_1.Transports.Movement;
using CPro_1.Enums;

namespace CPro_1.Transports
{
    public abstract class BaseTransport : IPeapleInTransport, IGetInformation, IGetSpeed, IEngeen
    {
        private string? nameOfTransport = default;

        private int comfortStars = default;

        private double speed = default;

        public BaseTransport() { }

        public BaseTransport(string baseEngine, DoorPosition doorPosition, string moves)
        {
            BaseEngine = new BaseEngine((TypeEngineEnum)Enum.Parse(typeof(TypeEngineEnum), baseEngine));
            DoorPosition = doorPosition;
            MoveTransport = new MoveTransport(moves);
        }

        public string? NameOfTransport { get => nameOfTransport; set { nameOfTransport = value; } }
        public double Speed { get { return speed; } set { speed = value; } }

        public BaseEngine BaseEngine { get; set; }

        public DoorPosition DoorPosition { get; set; }

        public MoveTransport MoveTransport { get; set; }

        Random random = new Random();

        public abstract int NumPeople();

        protected virtual double WeightTransport()
        {
            return random.Next(20, 60);
        }        

        public virtual void ShowInfo()
        {
            comfortStars = random.Next(1, 5);
            Console.WriteLine("Name of transport: {0}\n" +
                "Ease of movement: {1}\n" +
                "Type of Engine: {2}\n" +
                "Position of doors: {3}\n" +
                "State of transport: {4}\n" +
                "Speed: {5}",
                nameOfTransport, Helppppppp.ComfortStars(comfortStars), BaseEngine.TypeEngine, 
                DoorPosition.OpenClose, MoveTransport.Move, speed);
        }

    }
}
