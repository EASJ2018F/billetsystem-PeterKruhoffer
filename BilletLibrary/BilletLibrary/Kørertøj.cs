using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class Kørertøj
    {
        public string Nummerplade
        {
            get
            {
                if (Nummerplade.Length > 7)
                {
                    throw new ArgumentException("Max 7 tegn i nummerplade");
                }
                return Nummerplade;
            }
            set { value = Nummerplade; }
        }

        public DateTime Dato
        {
            get { return Dato; }
        }

        public Kørertøj(string Nummerplade)
        {
            
        }
        public abstract int Pris();

        public abstract string TypeAfKørertøj();
    }
}
