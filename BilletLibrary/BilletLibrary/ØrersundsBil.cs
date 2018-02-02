using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class ØrersundsBil : Kørertøj
    {
        public ØrersundsBil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        public override int Pris(int pris)
        {
            if (HarBrobizz)
            {
                return 161;
            }
            return 410;
        }

        public override string TypeAfKørertøj()
        {
            return "Ørersund Bil";
        }
    }
}
