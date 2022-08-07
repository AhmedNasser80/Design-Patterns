using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Observer
{
    class Referee : IObserver
    {
        private Position ballPosition;

        public Position BallPosition
        {
            get { return ballPosition; }
            set { ballPosition = value; }
        }

        public void Update()
        {
            Console.WriteLine("Referee Change His Position");
        }
    }
}
