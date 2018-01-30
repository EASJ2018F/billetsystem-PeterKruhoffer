using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLib
{
    public class MC
    {
        public string Nummerplade
        {
            get { return Nummerplade; }
        }

        public DateTime Dato
        {
            get { return Dato; }
        }
        public int Pris()
        {
            return 125;
        }

        public string Kørertøj()
        {
            return "MC";
        }
    }
}
