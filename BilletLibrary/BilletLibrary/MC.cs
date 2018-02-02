using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : Kørertøj
    {
        public override int Pris()
        {
            if (HarBrobizz)
            {
                return 125 - (5 / 100);
            }
            return 125;
        }

        public override string TypeAfKørertøj()
        {
            return "MC";
        }

        public MC(string Nummerplade, DateTime dato) : base(Nummerplade, dato)
        {
        }
    }
}
