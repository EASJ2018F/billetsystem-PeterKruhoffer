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
        private DateTime _dato;
        private bool _brobizz;
        public string Nummerplade
        {
            get { return _nummerplade; }
            set { _nummerplade = value; }
        }

        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        public bool HarBrobizz
        {
            get { return _brobizz; }
            set { _brobizz = value; }
        }

        public Kørertøj(string nummerplade, DateTime dato)
        {
            _nummerplade = nummerplade;
            _dato = dato;
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("Max 7 tegn i nummerplade");
            }
        }

        public abstract int Pris(int pris);

        public abstract string TypeAfKørertøj();
    }
}
