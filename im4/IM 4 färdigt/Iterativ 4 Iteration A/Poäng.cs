using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativgöraom
{
    class Poäng
    {
        private int _poäng;
        private int _medel;
        private int[] _namn; 

        /// <summary>
        /// Sätter att poäng endast kan vara mellan 1-10.
        /// </summary>
        public int Delatagarefel
        {
            get { return _poäng; }
            set
            {
                if (value > 10 || value < 1)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _poäng = value;
            }
        }

        /// <summary>
        /// Sätter så att det måste alltid finnas en 
        /// </summary>
        public int[] Domare
        {
            get { return _namn; }
            set
            {
                if (value.Length < 1)
                {
                    throw new ArgumentOutOfRangeException();
                } 
                _namn = value;
            }
        }

        /// <summary>
        /// Sätter så att om något index är tomt, då kastas ett undantag.
        /// </summary>
        public void Index()
       { 
            for (int i = 0; i < _namn.Length; i++)
            {
                if (_namn[i] < 1)
                {
                    throw new ArgumentException("En eller fler domare har ej betygsatt.");
                }
            }
        }


        /// <summary>
        /// Räknar ut medelvärde.
        /// </summary>
        public void medelvärde()
        {
            int sum = 0;

            for (int i = 0; i < _namn.Length; i++)
            {
                sum += _namn[i];
            }

            _medel = sum / _namn.Length;

            Console.WriteLine(_medel);
        }


    }
}
