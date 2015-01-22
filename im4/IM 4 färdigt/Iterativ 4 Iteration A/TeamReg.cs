using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Iterativgöraom
{
    class TeamReg
    {
        private string _teamName;
        private string _correctName;
        private int _members;
        private int _nomembers;

        /// <summary>
        /// Lagnamnet måste vara mellan 6 bokstäver och 30 bokstäver.
        /// </summary>
        public string Teamname
        {
            get { return _teamName; }
            set
            {
                if(value.Length < 6 || value.Length > 30)
                {
                    throw new ArgumentException("Lagnamnet måste vara mellan 6-30 bokstäver");
                }
                _teamName = value;
            }
        }

        /// <summary>
        /// Sätter så att lagnamnet måste börja med stor bokstav, mm.
        /// </summary>
        public string Correcteamname
        {
            get { return _correctName; }
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Z]+[a-zA-Z]*$"))
                {
                    throw new ArgumentException("Lagnamnet börjar ej med stor bokstav!");
                }
                _correctName = value;
            }
        }

        /// <summary>
        /// Sätter så att det måste vara mellan 5-12 medlemmar i ett lag.
        /// </summary>
        public int Teammembers
        {
            get { return _members; }
            set
            {
                if (value <= 5 || value >= 12)
                {
                    throw new ArgumentException("Antalet medlemar i ett lag måste vara mellan 5-12.");
                }
                _members = value;
            }
        }

        /// <summary>
        /// Sätter att man ej kan mata in 0 medlemmar.
        /// </summary>
        public int Nomembers
        {
            get { return _nomembers; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Du har ej fyllt i antalet medlemmar.");
                }
                _nomembers = value;
            }
        }
    }
}
