using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.User
{
    public class UserClass:IUser
    {
        public string name;
        public int age;
        public string address;

        public UserClass() { }

        public string Name => name;

        public string Address => address;

        public int Age => age;

    }
}
