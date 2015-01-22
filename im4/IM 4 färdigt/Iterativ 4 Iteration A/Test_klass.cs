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

            try
            {
                validateEmail.Email = "hej@student.com";
                text("TestEmailPass lyckades", true);
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
                text(error.Message, false);
            }
        }

        public static void TestValidatefail()
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
                text(error.Message, false);
            }
        }

        //Iteration B
        //------------------------------------------------------------------

            /// <summary>
            /// Kollar så att lagnamnet är mellan 6-30 bokstäver.
            /// </summary>
            public static void Teamnamecorrect()
        {
            var teamReg = new TeamReg();
                try
                {
                    teamReg.Teamname = "Testing";
                    text("Lagnamnet är korrekt inmatat", true);
                }
                catch (ArgumentOutOfRangeException error)
                {
                    text(error.Message, false);
                }
        }

            /// <summary>
            /// Kollar om lagnamnet inte är mellan 6-30 bokstäver.
            /// </summary>
            public static void Teamnameincorrect()
            {
                var teamReg = new TeamReg();
                try
                {
                    teamReg.Teamname = "test";
                }
                catch (ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

            /// <summary>
            /// Lagnamnet har stor bokstav i början.
            /// </summary>
            public static void Teambiglettercorrect()
            {
                var bigLetter = new TeamReg();
                try
                {
                    bigLetter.Correcteamname = "Thebigletters";
                    text("Godkänt pga stor bokstav i början.", true);
                }
                catch (ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

            /// <summary>
            /// Lagnamnet har ej storbokstav i början.
            /// </summary>
            public static void Teambigletterincorrect()
            {
                var bigLetter = new TeamReg();
                try
                {
                    bigLetter.Correcteamname = "thereisnobigletter";
                }
                catch (ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

            /// <summary>
            /// Testar sätta en korrekt mängd medlemmar.
            /// </summary>
            public static void correctamountofmembers()
            {
                var members = new TeamReg();
                try
                {
                    members.Teammembers = 10;
                    text("En godkänd mängd medlemmar", true);
                }
                catch (ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

           /// <summary>
           /// Provar mata in en ej korrekt mängd medlemmar.
           /// </summary>
            public static void incorrectamountofmembers()
            {
                var members = new TeamReg();
                try
                {
                    members.Teammembers = 3;
                }
                catch (ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

            /// <summary>
            /// Om man ej matar in några medlemmar.
            /// </summary>
            public static void Nomembers()
            {
                var nomembers = new TeamReg();
                try
                {
                    nomembers.Nomembers = 0;
                }
                catch (ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

            //Iteration C
            //---------------------------------------------------


            /// <summary>
            /// Testar om man matar in ett tal över godkänt värde.
            /// </summary>
        public static void Pointsincorrect1()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 11;
                text("Icke godkänt värde! Poängen måste vara mellan 1-10", false);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

        /// <summary>
        /// Testar om man matar in ett tal under godkänt värde.
        /// </summary>

        public static void Pointsincorrect2()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 0;
                text("Icke godkänt värde! Poängen måste vara mellan 1-10", false);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            /// <summary>
            /// Testar så att alla godkända värden fungerar.
            /// </summary>
            public static void Pointscorrect1()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 1;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect2()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 2;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect3()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 3;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect4()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 4;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect5()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 5;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect6()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 6;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect7()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 7;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect8()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 8;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect9()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 9;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            public static void Pointscorrect10()
        {
            var poäng = new Poäng();
            try
            {
                poäng.Delatagarefel = 10;
                text("Godkänt värde", true);
            }
            catch (ArgumentOutOfRangeException error)
            {
                text(error.Message, false);
            }
        }

            /// <summary>
            /// Testar ifall det saknas poäng från domarna så kommer det felmeddelande.
            /// </summary>
            public static void Testindexfail()
            {
                var poäng = new Poäng();
                poäng.Domare = new int[5];

                for (int i = 0; i < poäng.Domare.Length; i++)
                {
                    if (i != 1)
                    {
                        poäng.Domare[i] = 5;
                    }
                }
                try
                {
                    poäng.Index();
                    text("Test misslyckades", false);
                }
                catch(ArgumentException error)
                {
                    text(error.Message, false);
                }
            }

            /// <summary>
            /// Om alla domare har gett poäng, så blir testet godkänt.
            /// </summary>
            public static void Testindexcorrect()
            {
                var poäng = new Poäng();
                poäng.Domare = new int[5];

                for (int i = 0; i < poäng.Domare.Length; i++)
                {
                    
                    
                        poäng.Domare[i] = 5;
                }
                try
                {
                    poäng.Index();
                    text("Test lyckades", true);
                }
                catch(ArgumentException error)
                {
                    text(error.Message, false);
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
