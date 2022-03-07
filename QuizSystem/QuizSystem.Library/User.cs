using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem.Library
{
    public class User
    {
        public User(string email)
        {
            Email = email;
        }

        public string Email { get; }

    }
}
