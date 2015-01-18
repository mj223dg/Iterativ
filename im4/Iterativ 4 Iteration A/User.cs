using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Iterativgöraom
{
    class User
    {
    private string _txtPass;
    private string _txtUser;
    private string _email;

    public string PassWord
    {
        get { return _txtPass; }
        set
        {
        if(value.Length > 12)
        {
        throw new ArgumentOutOfRangeException();
        }
        _txtPass = value;
        }
    }

    public string Email
    {
        get { return _email; }
        set
        {
            if (!Regex.IsMatch(value, @"^[0-9a-z.]{1,64}@[a-z]*?\.[a-z]{2,}$"))
            {
                throw new ArgumentException("INTE LOL");
            }
            _email = value;
        }
    }

    public string Username
    {
        get { return _txtUser; }
        set
        {
        if(value.Length > 35)
        {
        throw new ArgumentOutOfRangeException();
        }
        _txtUser = value;
        }
    }

    public User(string txtPass, string txtUser)
        {
            PassWord = txtPass;
            Username = txtUser;
        }

    public User()
        {

        }

    }
}
