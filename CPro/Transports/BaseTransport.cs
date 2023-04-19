﻿using CPro_1.Helper;
using CPro_1.Interface;
using CPro_1.Transports.Door;
using CPro_1.Transports.TypeEngine;
using CPro_1.Transports.Movement;

namespace CPro_1.Transports
{
    public abstract class BaseTransport : IPeapleInTransport
    {
        private string? nameOfTransport = default;

        private int comfortStars = default;

        public BaseTransport(BaseEngine baseEngine, DoorPosition doorPosition, string moves)
        {
            BaseEngine = baseEngine;
            DoorPosition = doorPosition;
            MoveTransport = new MoveTransport(moves);
        }

        public string NameOfTransport { set { nameOfTransport = value; } }

        public BaseEngine BaseEngine { get; private set; }

        public DoorPosition DoorPosition { get; private set; }

        public MoveTransport MoveTransport { get; private set; }

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
                "State of transport: {4}",
                nameOfTransport, Helppppppp.ComfortStars(comfortStars), BaseEngine.TypeEngine, 
                DoorPosition.OpenClose, MoveTransport.Move);
        }

    }
}