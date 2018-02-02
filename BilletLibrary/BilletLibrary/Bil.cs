using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Kørertøj
    {
        public override int Pris()
        {
            return 240;
        }

        public override string TypeAfKørertøj()
        {
            return "Bil";
        }


        public Bil(string Nummerplade) : base(Nummerplade)
        {
        }
    }
}
