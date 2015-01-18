using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativgöraom
{
        class Test_klass
        {
        /// <summary>
        /// Testar så att det går att sätta ett lösenord som är inom den korrekta längden
        /// </summary>
            public static void TestPasswordCorrect()
            {
                    var pass = new Validate();
                try
                {
                    pass.Password = "aaaaa";
                    text("Lösenordet har rätt längd", true);
                }
                catch(ArgumentOutOfRangeException error)
                {
                    text(error.Message, false);
                }
            }
        /// <summary>
        /// Testar så att det ej går att mata in längre lösenord än 12 tecken.
        /// </summary>

        public static void TestPasswordIncorrect()
            {
                    var pass = new Validate();
                try
                {
                    pass.Password = "aaaaaaaaaaaaa";
                    text("TestPasswordIncorrect misslyckades!", false);
                }
                catch(ArgumentOutOfRangeException error)
                {
                   text(error.Message, false);
                }
            }

        /// <summary>
        /// Testar så att det blir korrekt om användaren matar in rätt längd på användarnamnet.
        /// </summary>

        public static void TestUsernameCorrect()
            {
                    var use = new Validate();
                try
                {
                    use.Usename = "aaaaaaaaaaaaaaaaaa";
                    text("Användarnamnet är godkänt!", true);
                }
                catch (ArgumentOutOfRangeException error)
                {
                    text(error.Message, false);
                }
            }

        /// <summary>
        /// Testar så att det ej går att mata in ett användarnamn än som är förbjudet.
        /// </summary>

        public static void TestUsernameIncorrect()
            {
                    var use = new Validate();
                try
                {
                    use.Usename = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                    text("Användarnamnet är för långt!", true);
                }
                catch(ArgumentOutOfRangeException error)
                {
                    text(error.Message, false);
                }
            }

        /// <summary>
        /// Testar så att man ej kan skriva fel i mailen.
        /// </summary>
        public static void TestEmailFail()
        {
            var validate = new User();
            //validate.Validatemail("hej.com");

            try
            {
                validate.Email = "hej.com";
                text("TestEmailFail misslyckades", false);
            }
            catch (ArgumentException error)
            {
                text(error.Message, false);
            }
        }

        /// <summary>
        /// Testar så att man kan skriva korrekt i mailen.
        /// </summary>
        public static void TestEmailPass()
        {
            var validateEmail = new User();
            //validate.Validatemail("hej.com");

            try
            {
                validateEmail.Email = "hej@student.com";
                text("TestEmailPass lyckades", false);
            }
            catch (ArgumentException error)
            {
                text(error.Message, false);
            }
        }

        public static void TestValidate()
        {
            var validator = new Validate("hej", "123");
            var user = new User("hej", "123");
            try
            {
                validator.ValidatePassword(user);
                text("Lösenord och användarnamn är godkänt", true);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message, false);
            }
        }

        public static void WrongTestValidate()
        {
            var validator = new Validate("hej", "1233");
            var user = new User("hej", "123");
            try
            {
                validator.ValidatePassword(user);
                text("Lösenord och användarnamn fel", true);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message, false);
            }
        }

        public static void text(string message, bool trueOrFalse)
        {
            if (trueOrFalse == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(message);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
            }
            Console.ResetColor();
        }
    }
}
