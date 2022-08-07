using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DP
{
    class PlayerRole : Player
    {
        private Player _player;

        public PlayerRole(Player P)
            => this._player = P;

        public override void PassBall()
            => Console.WriteLine("Player is Passing The Ball");

    }
    class Forward:PlayerRole
    {
        public Forward(Player P):base(P)
        {

        }
        public void Shoot()
            => Console.WriteLine("Player is Shooting The Ball");
    }
    class MidPlayer : PlayerRole
    {
        public MidPlayer(Player P) : base(P)
        {

        }
        public void Dribble ()
            => Console.WriteLine("Player is Dribbling");
    }
    class Defender : PlayerRole
    {
        public Defender(Player P) : base(P)
        {

        }
        public void Defend()
            => Console.WriteLine("Player is Defending");
    }
}
