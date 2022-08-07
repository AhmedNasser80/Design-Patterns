using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Observer
{
    class Player : IObserver
    {

        private Position ballPosition;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Position BallPosition
        {
            get { return ballPosition; }
            set { ballPosition = value; }
        }

        public Player(string name)
        {
            this.name = name;
        }

        public void Update()
        {
            Console.WriteLine("Player Change His Position");
        }
    }
}
