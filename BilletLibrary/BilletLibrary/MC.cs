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
            return 125;
        }

        public override string TypeAfKørertøj()
        {
            return "MC";
        }

        public MC(string Nummerplade) : base(Nummerplade)
        {
        }
    }
}
