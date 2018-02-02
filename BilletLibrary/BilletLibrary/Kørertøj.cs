using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class Kørertøj
    {
        private string _nummerplade;
        public string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }

        public DateTime Dato
        {
            get { return Dato; }
        }

        public Kørertøj(string nummerplade)
        {
            _nummerplade = nummerplade;
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("Max 7 tegn i nummerplade");
            }
        }
        public abstract int Pris();

        public abstract string TypeAfKørertøj();
    }
}
