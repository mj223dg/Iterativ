using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativgöraom
{
   class Validate
        {
            private string _password;
            private string _userName;

            public Validate(string password, string user)
            {
                _password = password;
                _userName = user;
            //string returnline = ValidatePassword(passwords, users);
            //Console.WriteLine(returnline);
            }

            public Validate()
            {
            }

            public string Password
            {
                get { return _password; }
                set
                {
                    if (value.Length > 12)
                    {
                        throw new ArgumentOutOfRangeException("Lösenordet är för långt.");
                    }
                    _password = value;
                }
            }

            public string Usename
            {
            get { return _userName; }
            set
            {
            if (value.Length > 35)
            {
            throw new ArgumentOutOfRangeException("Användarnamnet är för långt.");
            }
            _userName = value;
            }
            }

            public string ValidatePassword(User a)
            {
            if (_userName == a.Username && _password == a.PassWord)
            {
            return "Korrekta inloggningsuppgifter.";
            }
            else
            {
            throw new ArgumentException();
            }
        }
    }
}
