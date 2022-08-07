using System;

namespace Decorator_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            FieldPlayer fieldPlayer = new FieldPlayer() { Name = "Messi" };

            Forward forward = new Forward(fieldPlayer);
               Defender defender = new Defender(forward);

        }
    }
}
