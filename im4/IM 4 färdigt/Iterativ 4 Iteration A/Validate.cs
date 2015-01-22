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
            }

            public Validate()
            {
            }

       /// <summary>
       /// Sätter så att lösenordet inte inte kan vara längre än 12 tecken.
       /// </summary>
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

       /// <summary>
       /// Sätter så att användarnamnet endast kan vara upp till 35 tecken.
       /// </summary>
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

       /// <summary>
       /// Jämför lösenordet och användarnamnet.
       /// </summary>

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
