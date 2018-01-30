using System;

namespace BilletLib
{
    public class Bil
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
            return 240;
        }

        public string Kørertøj()
        {
            return "Bil";
        }
    }
}
