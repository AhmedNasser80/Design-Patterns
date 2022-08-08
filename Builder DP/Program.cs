using Builder_DP.User;
using System;

namespace Builder_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
          UserClass user = new User.UserBuilder().WithName("John").WithAddress("123 Street").Build();

        }
    }
}
