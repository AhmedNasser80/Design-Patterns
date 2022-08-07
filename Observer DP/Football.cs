using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Observer
{
    class Football:Ball
    {
        private Position myPostion;

        public Football(Position _myPosition)
        {
            myPostion = _myPosition;
        }

        public Position GetBallPostion()
            => this.myPostion;
        public void SetBallPosition(Position newPosition)
            => this.myPostion = newPosition;

    }
}
