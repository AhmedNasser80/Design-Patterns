using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.User
{
    public class UserBuilder
    {
        private readonly UserClass user;

        public UserBuilder()
        {
            user = new UserClass();
        }

        public UserBuilder WithName(string name)
        {
            user.name = name;
            return this;
        }

        public UserBuilder WithAge(int age)
        {
            user.age = age;
            return this;
        }

        public UserBuilder WithAddress(string address)
        {
            user.address = address;
            return this;
        }

        public UserClass Build() => user;
    }
}

